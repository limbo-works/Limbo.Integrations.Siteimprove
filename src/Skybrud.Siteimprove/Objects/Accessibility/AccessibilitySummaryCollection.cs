using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Siteimprove.Objects.Links;

namespace Skybrud.Siteimprove.Objects.Accessibility {

    public class AccessibilitySummaryCollection : SiteimproveObject {

        private readonly Dictionary<string, int> _lookup = new Dictionary<string, int>();

        #region Properties

        [JsonProperty("items")]
        public AccessibilitySummaryItem[] Items { get; private set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; private set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; private set; }

        #endregion

        #region Constructor

        private AccessibilitySummaryCollection(JObject obj) : base(obj) { }

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

        public static AccessibilitySummaryCollection Parse(JObject obj) {
            
            if (obj == null) return null;
            
            AccessibilitySummaryCollection collection = new AccessibilitySummaryCollection(obj) {
                Items = obj.GetArray("items", AccessibilitySummaryItem.Parse),
                TotalItems = obj.GetInt32("total_items"),
                TotalPages = obj.GetInt32("total_pages")
            };

            foreach (AccessibilitySummaryItem result in collection.Items) {
                collection._lookup.Add(result.ConformanceLevel + "_" + result.Severity, result.Issues);
            }

            return collection;

        }

        #endregion

    }

}
