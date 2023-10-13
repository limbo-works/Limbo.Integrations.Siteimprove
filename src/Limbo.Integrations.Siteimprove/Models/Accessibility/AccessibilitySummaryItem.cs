using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.Accessibility {

    public class SiteimproveAccessibilitySummaryItem : SiteimproveObject {

        #region Properties

        public SiteimproveAccessibilityConformanceLevel ConformanceLevel { get; }

        public SiteimproveAccessibilitySeverity Severity { get; }

        public int Issues { get; }

        #endregion

        #region Constructor

        private SiteimproveAccessibilitySummaryItem(JObject obj) : base(obj) {
            ConformanceLevel = obj.GetEnum<SiteimproveAccessibilityConformanceLevel>("conformance_level");
            Issues = obj.GetInt32("issues");
            Severity = obj.GetEnum<SiteimproveAccessibilitySeverity>("severity");
        }

        #endregion

        #region Static methods

        public static SiteimproveAccessibilitySummaryItem Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAccessibilitySummaryItem(obj);
        }

        #endregion

    }

}