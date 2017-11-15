using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Siteimprove.Objects.Accessibility.Pages {

    public class PageAccessibilityIssuesItem : SiteimproveObject {

        #region Properties

        public AccessibilityConformanceLevel ConformanceLevel { get; }

        public AccessibilitySeverity Severity { get; }

        public int Issues { get; }

        #endregion

        #region Constructor

        private PageAccessibilityIssuesItem(JObject obj) : base(obj) {
            ConformanceLevel = obj.GetEnum<AccessibilityConformanceLevel>("conformance_level");
            Issues = obj.GetInt32("issues");
            Severity = obj.GetEnum<AccessibilitySeverity>("severity");
        }

        #endregion

        #region Static methods

        public static PageAccessibilityIssuesItem Parse(JObject obj) {
            return obj == null ? null : new PageAccessibilityIssuesItem(obj);
        }

        #endregion

    }

}