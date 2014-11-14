using System.Collections.Generic;
using Newtonsoft.Json;
using Skybrud.Siteimprove.Objects.Links;
using Skybrud.Social;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Objects.Accessibility {

    public class AccessibilityCollection : SocialJsonObject {

        private Dictionary<string, int> _lookup = new Dictionary<string, int>();

        #region Properties

        [JsonProperty("items")]
        public AccessibilityResult[] Items { get; private set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; private set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; private set; }

        [JsonProperty("_siteimprove")]
        public LinksCollection Siteimprove { get; private set; }

        #endregion

        #region Constructor

        private AccessibilityCollection(JsonObject obj) : base(obj) { }

        #endregion

        #region Methods

        public bool HasIssue(AccessibilityConformanceLevel level, AccessibilitySeverity severity) {
            return _lookup.ContainsKey(level + "_" + severity);
        }

        public AccessibilityIssueSummary GetIssueSummary(AccessibilityConformanceLevel level) {
            return new AccessibilityIssueSummary {
                Errors = GetIssueCount(level, AccessibilitySeverity.Error),
                Warnings = GetIssueCount(level, AccessibilitySeverity.Warning),
                Reviews = GetIssueCount(level, AccessibilitySeverity.Review)
            };
        }

        public int GetIssueCount(AccessibilityConformanceLevel level, AccessibilitySeverity severity) {
            int value;
            return _lookup.TryGetValue(level + "_" + severity, out value) ? value : 0;
        }

        #endregion

        #region Static methods

        public static AccessibilityCollection Parse(JsonObject obj) {
            
            if (obj == null) return null;
            
            AccessibilityCollection collection = new AccessibilityCollection(obj) {
                Items = obj.GetArray("items", AccessibilityResult.Parse),
                TotalItems = obj.GetInt32("total_items"),
                TotalPages = obj.GetInt32("total_pages"),
                Siteimprove = obj.GetObject("_siteimprove", LinksCollection.Parse)
            };

            foreach (AccessibilityResult result in collection.Items) {
                collection._lookup.Add(result.ConformanceLevel + "_" + result.Severity, result.IssueCount);
            }

            return collection;

        }

        #endregion

    }

}
