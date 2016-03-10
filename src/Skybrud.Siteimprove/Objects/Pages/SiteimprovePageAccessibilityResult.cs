using System;
using Newtonsoft.Json.Linq;
using Skybrud.Siteimprove.Objects.Accessibility;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Pages {
    
    public class SiteimprovePageAccessibilityResult : SiteimproveObject {

        #region Properties

        public AccessibilityConformanceLevel ConformanceLevel { get; private set; }

        public AccessibilitySeverity Severity { get; private set; }

        public int IssueCount { get; private set; }

        #endregion

        #region Constructor

        private SiteimprovePageAccessibilityResult(JObject obj) : base(obj) {
            
            // Parse the issue count
            IssueCount = obj.GetInt32("issue_count");

            // Parse the conformance level
            string level = obj.GetString("conformance_level");
            switch (level) {
                case "A": ConformanceLevel = AccessibilityConformanceLevel.A; break;
                case "AA": ConformanceLevel = AccessibilityConformanceLevel.AA; break;
                case "AAA": ConformanceLevel = AccessibilityConformanceLevel.AAA; break;
                default: throw new Exception("Unable to parse the conformance level \"" + level + "\"");
            }

            // Parse the severity
            string severity = obj.GetString("severity");
            switch (severity) {
                case "Error": Severity = AccessibilitySeverity.Error; break;
                case "Warning": Severity = AccessibilitySeverity.Warning; break;
                case "Review": Severity = AccessibilitySeverity.Review; break;
                default: throw new Exception("Unable to parse the severity \"" + severity + "\"");
            }

        }

        #endregion

        #region Static methods

        public static SiteimprovePageAccessibilityResult Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePageAccessibilityResult(obj);
        }

        #endregion

    }

}