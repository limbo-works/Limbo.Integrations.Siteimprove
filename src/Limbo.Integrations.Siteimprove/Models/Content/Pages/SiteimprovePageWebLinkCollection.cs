using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.Content.Pages {

    public class SiteimprovePageWebLinkCollection : SiteimproveObject {

        #region Properties

        public SiteimprovePageWebLinkItem Accessibility { get; }

        public SiteimprovePageWebLinkItem Policy { get; }

        public SiteimprovePageWebLinkItem QualityAssurance { get; }

        public SiteimprovePageWebLinkItem Seo { get; }

        #endregion

        #region Constructors

        private SiteimprovePageWebLinkCollection(JObject obj) : base(obj) {
            Accessibility = obj.GetObject("accessibility", SiteimprovePageWebLinkItem.Parse);
            Policy = obj.GetObject("policy", SiteimprovePageWebLinkItem.Parse);
            QualityAssurance = obj.GetObject("quality_assurance", SiteimprovePageWebLinkItem.Parse);
            Seo = obj.GetObject("seo", SiteimprovePageWebLinkItem.Parse);
        }

        #endregion

        #region Static methods

        public static SiteimprovePageWebLinkCollection Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePageWebLinkCollection(obj);
        }

        #endregion

    }

}