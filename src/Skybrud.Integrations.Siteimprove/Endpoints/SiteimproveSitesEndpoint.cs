using Skybrud.Integrations.Siteimprove.Endpoints.Raw;
using Skybrud.Integrations.Siteimprove.Models.Sites;
using Skybrud.Integrations.Siteimprove.Responses;
using Skybrud.Integrations.Siteimprove.Responses.Sites;

namespace Skybrud.Integrations.Siteimprove.Endpoints {

    public class SiteimproveSitesEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveSitesRawEndpoint Raw => Service.Client.Sites;

        #endregion

        #region Constructors

        internal SiteimproveSitesEndpoint(SiteimproveService service) {
            Service = service;
        }

        #endregion

        #region Methods

        public SiteimproveResponse<SiteimproveSite> GetSite(int siteId) {
            return SiteimproveGetSiteResponse.ParseResponse(Raw.GetSite(siteId));
        }

        public SiteimproveGetSitesResponse GetSites() {
            return GetSites(0, 0);
        }

        public SiteimproveGetSitesResponse GetSites(int pageSize) {
            return GetSites(0, pageSize);
        }

        public SiteimproveGetSitesResponse GetSites(int page, int pageSize) {
            return SiteimproveGetSitesResponse.ParseResponse(Raw.GetSites(page, pageSize));
        }

        #endregion

    }

}