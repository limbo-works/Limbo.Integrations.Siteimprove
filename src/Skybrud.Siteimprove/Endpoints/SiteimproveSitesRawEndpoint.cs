using System.Collections.Specialized;
using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Endpoints {

    public class SiteimproveSitesRawEndpoint {

        #region Properties

        public SiteimproveClient Client { get; private set; }

        #endregion

        #region Constructor

        internal SiteimproveSitesRawEndpoint(SiteimproveClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        public SocialHttpResponse GetSite(int siteId) {
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrl + "/sites/" + siteId);
        }

        public SocialHttpResponse GetSites() {
            return GetSites(0, 0);
        }

        public SocialHttpResponse GetSites(int size) {
            return GetSites(0, 0);
        }

        public SocialHttpResponse GetSites(int page, int pageSize) {

            NameValueCollection query = new NameValueCollection();
            if (page > 0) query.Add("page", page + "");
            if (pageSize > 0) query.Add("page_size", pageSize + "");

            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrl + "/sites", query);

        }

        #endregion

    }

}