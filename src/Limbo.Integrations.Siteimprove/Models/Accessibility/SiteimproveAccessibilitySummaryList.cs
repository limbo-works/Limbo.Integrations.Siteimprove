using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.Accessibility {

    public class SiteimproveAccessibilitySummaryList : SiteimproveObject {

        private readonly Dictionary<string, int> _lookup = new Dictionary<string, int>();

        #region Properties

        [JsonProperty("items")]
        public SiteimproveAccessibilitySummaryItem[] Items { get; }

        [JsonProperty("total_items")]
        public int TotalItems { get; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; }

        [JsonIgnore]
        public string WebApp { get; }

        #endregion

        #region Constructor

        private SiteimproveAccessibilitySummaryList(JObject obj) : base(obj) {

            Items = obj.GetArray("items", SiteimproveAccessibilitySummaryItem.Parse);
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
            WebApp = obj.GetString("siteimprove.webapp.href");

            foreach (SiteimproveAccessibilitySummaryItem result in Items) {
                _lookup.Add(result.ConformanceLevel + "_" + result.Severity, result.Issues);
            }

        }

        #endregion

        #region Methods

        public bool HasIssue(SiteimproveAccessibilityConformanceLevel level, SiteimproveAccessibilitySeverity severity) {
            return _lookup.ContainsKey(level + "_" + severity);
        }

        public SiteimproveAccessibilityIssueSummary GetIssueSummary(SiteimproveAccessibilityConformanceLevel level) {
            return new SiteimproveAccessibilityIssueSummary {
                Errors = GetIssueCount(level, SiteimproveAccessibilitySeverity.Error),
                Warnings = GetIssueCount(level, SiteimproveAccessibilitySeverity.Warning),
                Reviews = GetIssueCount(level, SiteimproveAccessibilitySeverity.Review)
            };
        }

        public int GetIssueCount(SiteimproveAccessibilityConformanceLevel level, SiteimproveAccessibilitySeverity severity) {
            return _lookup.TryGetValue(level + "_" + severity, out int value) ? value : 0;
        }

        #endregion

        #region Static methods

        public static SiteimproveAccessibilitySummaryList Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAccessibilitySummaryList(obj);
        }

        #endregion

    }

}