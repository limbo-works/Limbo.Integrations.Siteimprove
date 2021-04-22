using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Integrations.Siteimprove.Models.Accessibility.Pages {

    /// <summary>
    /// Class representing an accessibility issue.
    /// </summary>
    public class SiteimproveAccessibilityPageIssuesItem : SiteimproveObject {

        #region Properties

        public SiteimproveAccessibilityConformanceLevel ConformanceLevel { get; }

        public SiteimproveAccessibilitySeverity Severity { get; }

        public int Issues { get; }

        #endregion

        #region Constructor

        private SiteimproveAccessibilityPageIssuesItem(JObject obj) : base(obj) {
            ConformanceLevel = obj.GetEnum<SiteimproveAccessibilityConformanceLevel>("conformance_level");
            Issues = obj.GetInt32("issues");
            Severity = obj.GetEnum<SiteimproveAccessibilitySeverity>("severity");
        }

        #endregion

        #region Static methods

        public static SiteimproveAccessibilityPageIssuesItem Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAccessibilityPageIssuesItem(obj);
        }

        #endregion

    }

}