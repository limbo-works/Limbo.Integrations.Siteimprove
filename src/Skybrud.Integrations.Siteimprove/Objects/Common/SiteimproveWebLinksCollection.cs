using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Integrations.Siteimprove.Objects.Common {

    public class SiteimproveWebLinksCollection : SiteimproveLinksCollection {

        #region Properties

        [JsonProperty("page_report")]
        public string PageReport { get; private set; }

        #endregion

        #region Constructor

        private SiteimproveWebLinksCollection(JObject obj) : base(obj) {
            PageReport = obj.GetString("page_report");
        }

        #endregion

        #region Static methods

        public static new SiteimproveWebLinksCollection Parse(JObject obj) {
            return obj == null ? null : new SiteimproveWebLinksCollection(obj);
        }

        #endregion

    }

}