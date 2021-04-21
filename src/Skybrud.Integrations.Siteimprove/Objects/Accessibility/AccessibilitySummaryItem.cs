using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Integrations.Siteimprove.Objects.Accessibility {
    
    public class AccessibilitySummaryItem : SiteimproveObject {

        #region Properties

        public AccessibilityConformanceLevel ConformanceLevel { get; private set; }

        public AccessibilitySeverity Severity { get; private set; }

        public int Issues { get; private set; }

        #endregion

        #region Constructor

        private AccessibilitySummaryItem(JObject obj) : base(obj) {
            ConformanceLevel = obj.GetEnum<AccessibilityConformanceLevel>("conformance_level");
            Issues = obj.GetInt32("issues");
            Severity = obj.GetEnum<AccessibilitySeverity>("severity");
        }

        #endregion

        #region Static methods

        public static AccessibilitySummaryItem Parse(JObject obj) {
            return obj == null ? null : new AccessibilitySummaryItem(obj);
        }

        #endregion

    }

}