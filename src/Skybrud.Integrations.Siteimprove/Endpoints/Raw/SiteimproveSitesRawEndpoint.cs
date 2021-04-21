using System.Collections.Specialized;
using Skybrud.Social.Http;

namespace Skybrud.Integrations.Siteimprove.Endpoints.Raw {

    public class SiteimproveSitesRawEndpoint {

        #region Properties

        public SiteimproveClient Client { get; }

        #endregion

        #region Constructor

        internal SiteimproveSitesRawEndpoint(SiteimproveClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        public SocialHttpResponse GetSite(int siteId) {
            return Client.DoHttpGetRequest("/v2/sites/" + siteId);
        }

        public SocialHttpResponse GetSites() {
            return GetSites(0, 0);
        }

        public SocialHttpResponse GetSites(int pageSize) {
            return GetSites(0, pageSize);
        }

        public SocialHttpResponse GetSites(int page, int pageSize) {

            NameValueCollection query = new NameValueCollection();
            if (page > 0) query.Add("page", page + "");
            if (pageSize > 0) query.Add("page_size", pageSize + "");

            return Client.DoHttpGetRequest("/v2/sites", query);

        }

        #endregion

    }

}