using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.Content.Pages {
    
    public class SiteimprovePageSummary : SiteimproveObject {

        #region Properties

        public SiteimprovePageSummaryAccessibility Accessibility { get; }

        public SiteimprovePageSummaryPage Page { get; }

        public SiteimprovePageSummaryPolicy Policy { get; }

        public SiteimprovePageSummaryQualityAssurance QualityAssurance { get; }

        public SiteimprovePageSummarySeo Seo { get; }

        #endregion

        #region Constructors

        private SiteimprovePageSummary(JObject obj) : base(obj) {
            Accessibility = obj.GetObject("accessibility", SiteimprovePageSummaryAccessibility.Parse);
            Page = obj.GetObject("page", SiteimprovePageSummaryPage.Parse);
            Policy = obj.GetObject("policy", SiteimprovePageSummaryPolicy.Parse);
            QualityAssurance = obj.GetObject("quality_assurance", SiteimprovePageSummaryQualityAssurance.Parse);
            Seo = obj.GetObject("seo", SiteimprovePageSummarySeo.Parse);
        }

        #endregion

        #region Static methods

        public static SiteimprovePageSummary Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePageSummary(obj);
        }

        #endregion

    }

}