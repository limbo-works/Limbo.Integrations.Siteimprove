using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Skybrud.Siteimprove.Objects.Accessibility;
using Skybrud.Siteimprove.Objects.Common;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Pages {

    public class SiteimprovePageAccessibility : SiteimproveObject {

        private readonly Dictionary<string, int> _lookup = new Dictionary<string, int>();

        #region Properties

        public SiteimprovePageAccessibilityResult[] Issues { get; private set; }

        public SiteimproveWebLinksCollection Siteimprove { get; private set; }

        #endregion

        #region Constructor

        private SiteimprovePageAccessibility(JObject obj) : base(obj) {

            Issues = obj.GetArray("issues", SiteimprovePageAccessibilityResult.Parse);
            Siteimprove = obj.GetObject("_siteimprove", SiteimproveWebLinksCollection.Parse);

            foreach (SiteimprovePageAccessibilityResult result in Issues) {
                _lookup.Add(result.ConformanceLevel + "_" + result.Severity, result.IssueCount);
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

        public static SiteimprovePageAccessibility Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePageAccessibility(obj);
        }

        #endregion

    }
}