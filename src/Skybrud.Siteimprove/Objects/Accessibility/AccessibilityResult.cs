using System;
using Skybrud.Siteimprove.Objects.Links;
using Skybrud.Social;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Objects.Accessibility {
    
    public class AccessibilityResult : SocialJsonObject {

        #region Properties

        public AccessibilityConformanceLevel ConformanceLevel { get; private set; }

        public AccessibilitySeverity Severity { get; private set; }

        public int IssueCount { get; private set; }

        public LinksCollection Links { get; private set; }

        #endregion

        #region Constructor

        private AccessibilityResult(JsonObject obj) : base(obj) {}

        #endregion

        #region Static methods

        public static AccessibilityResult Parse(JsonObject obj) {

            // Initialize the result object
            AccessibilityResult result = new AccessibilityResult(obj) {
                IssueCount = obj.GetInt32("issue_count"),
                Links = obj.GetObject("_links", LinksCollection.Parse)
            };

            // Parse the conformance level
            string level = obj.GetString("conformance_level");
            switch (level) {
                case "A": result.ConformanceLevel = AccessibilityConformanceLevel.A; break;
                case "AA": result.ConformanceLevel = AccessibilityConformanceLevel.AA; break;
                case "AAA": result.ConformanceLevel = AccessibilityConformanceLevel.AAA; break;
                default: throw new Exception("Unable to parse the conformance level \"" + level + "\"");
            }

            // Parse the severity
            string severity = obj.GetString("severity");
            switch (severity) {
                case "Error": result.Severity = AccessibilitySeverity.Error; break;
                case "Warning": result.Severity = AccessibilitySeverity.Warning; break;
                case "Review": result.Severity = AccessibilitySeverity.Review; break;
                default: throw new Exception("Unable to parse the severity \"" + severity + "\"");
            }

            return result;

        }

        #endregion

    }

}
