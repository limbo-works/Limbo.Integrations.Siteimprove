using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.Accessibility.Pages {

    /// <summary>
    /// Class representing a list of accessibility issues.
    /// </summary>
    public class SiteimproveAccessibilityPageIssuesList : SiteimproveObject {

        private readonly Dictionary<string, int> _lookup = new Dictionary<string, int>();

        #region Properties
        
        public SiteimproveAccessibilityPageIssuesItem[] Items { get; }
        
        public int TotalItems { get; }
        
        public int TotalPages { get; }

        #endregion

        #region Constructor

        private SiteimproveAccessibilityPageIssuesList(JObject obj) : base(obj) {

            Items = obj.GetArray("items", SiteimproveAccessibilityPageIssuesItem.Parse);
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");

            foreach (SiteimproveAccessibilityPageIssuesItem result in Items) {
                _lookup[result.ConformanceLevel + "_" + result.Severity] = result.Issues;
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

        public static SiteimproveAccessibilityPageIssuesList Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAccessibilityPageIssuesList(obj);
        }

        #endregion

    }

}