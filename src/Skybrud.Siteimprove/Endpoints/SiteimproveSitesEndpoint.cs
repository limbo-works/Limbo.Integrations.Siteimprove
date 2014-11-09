using System.Collections.Specialized;
using Skybrud.Siteimprove.Endpoints.Raw;
using Skybrud.Siteimprove.Responses;
using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Endpoints {

    public class SiteimproveSitesEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; private set; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveSitesRawEndpoint Raw {
            get { return Service.Client.Sites; }
        }

        #endregion

        #region Constructors

        internal SiteimproveSitesEndpoint(SiteimproveService service) {
            Service = service;
        }

        #endregion

        #region Methods

        //public SocialHttpResponse GetSite(int siteId) {
        //    return Client.DoHttpGetRequest(SiteimproveClient.ApiUrl + "/sites/" + siteId);
        //}

        public SiteimproveSitesResponse GetSites() {
            return GetSites(0, 0);
        }

        public SiteimproveSitesResponse GetSites(int size) {
            return GetSites(0, 0);
        }

        public SiteimproveSitesResponse GetSites(int page, int pageSize) {
            return SiteimproveSitesResponse.ParseResponse(Raw.GetSites(page, pageSize));
        }

        #endregion

    }

}