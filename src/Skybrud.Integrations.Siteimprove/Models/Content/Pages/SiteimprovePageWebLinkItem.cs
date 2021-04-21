using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Integrations.Siteimprove.Models.Content.Pages {
    
    public class SiteimprovePageWebLinkItem : SiteimproveObject {

        #region Properties

        public string PageReport { get; }
        
        #endregion

        #region Constructors

        private SiteimprovePageWebLinkItem(JObject obj) : base(obj) {
            PageReport = obj.GetString("page_report.href");
        }

        #endregion

        #region Static methods

        public static SiteimprovePageWebLinkItem Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePageWebLinkItem(obj);
        }

        #endregion

    }

}