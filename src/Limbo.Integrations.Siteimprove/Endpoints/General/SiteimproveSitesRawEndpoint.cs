using Limbo.Integrations.Siteimprove.Http;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;

namespace Limbo.Integrations.Siteimprove.Endpoints.General {

    public class SiteimproveSitesRawEndpoint {

        #region Properties

        public SiteimproveHttpClient Client { get; }

        #endregion

        #region Constructor

        internal SiteimproveSitesRawEndpoint(SiteimproveHttpClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        public IHttpResponse GetSite(int siteId) {
            return Client.Get($"/v2/sites/{siteId}");
        }

        public IHttpResponse GetSites() {
            return GetSites(0, 0);
        }

        public IHttpResponse GetSites(int pageSize) {
            return GetSites(0, pageSize);
        }

        public IHttpResponse GetSites(int page, int pageSize) {

            IHttpQueryString query = new HttpQueryString();
            if (page > 0) query.Add("page", page);
            if (pageSize > 0) query.Add("page_size", pageSize);

            return Client.Get("/v2/sites", query);

        }

        #endregion

    }

}