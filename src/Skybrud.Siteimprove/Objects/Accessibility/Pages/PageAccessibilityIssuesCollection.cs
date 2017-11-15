using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Siteimprove.Objects.Accessibility.Pages {

    public class PageAccessibilityIssuesCollection : SiteimproveObject {

        private readonly Dictionary<string, int> _lookup = new Dictionary<string, int>();

        #region Properties
        
        public PageAccessibilityIssuesItem[] Items { get; }
        
        public int TotalItems { get; }
        
        public int TotalPages { get; }

        #endregion

        #region Constructor

        private PageAccessibilityIssuesCollection(JObject obj) : base(obj) {

            Items = obj.GetArray("items", PageAccessibilityIssuesItem.Parse);
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");

            foreach (PageAccessibilityIssuesItem result in Items) {
                _lookup[result.ConformanceLevel + "_" + result.Severity] = result.Issues;
            }

        }

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

        public static PageAccessibilityIssuesCollection Parse(JObject obj) {
            return obj == null ? null : new PageAccessibilityIssuesCollection(obj);
        }

        #endregion

    }

}