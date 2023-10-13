using Limbo.Integrations.Siteimprove.Models.Sites;
using Limbo.Integrations.Siteimprove.Responses;
using Limbo.Integrations.Siteimprove.Responses.Sites;

namespace Limbo.Integrations.Siteimprove.Endpoints.General {

    public class SiteimproveSitesEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveHttpService Service { get; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveSitesRawEndpoint Raw => Service.Client.Sites;

        #endregion

        #region Constructors

        internal SiteimproveSitesEndpoint(SiteimproveHttpService service) {
            Service = service;
        }

        #endregion

        #region Methods

        public SiteimproveResponse<SiteimproveSite> GetSite(int siteId) {
            return new SiteimproveSiteResponse(Raw.GetSite(siteId));
        }

        public SiteimproveSiteListResponse GetSites() {
            return GetSites(0, 0);
        }

        public SiteimproveSiteListResponse GetSites(int pageSize) {
            return GetSites(0, pageSize);
        }

        public SiteimproveSiteListResponse GetSites(int page, int pageSize) {
            return new SiteimproveSiteListResponse(Raw.GetSites(page, pageSize));
        }

        #endregion

    }

}