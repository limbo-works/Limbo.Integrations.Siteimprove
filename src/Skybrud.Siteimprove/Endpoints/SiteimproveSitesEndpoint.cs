using Skybrud.Siteimprove.Endpoints.Raw;
using Skybrud.Siteimprove.Objects;
using Skybrud.Siteimprove.Responses;

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

        public SiteimproveResponse<SiteimproveSite> GetSite(int siteId) {
            return SiteimproveHelpers.ParseResponse(Raw.GetSite(siteId), SiteimproveSite.Parse);
        }

        public SiteimproveResponse<SiteimproveSiteSummary> GetSites() {
            return GetSites(0, 0);
        }

        public SiteimproveResponse<SiteimproveSiteSummary> GetSites(int pageSize) {
            return GetSites(0, pageSize);
        }

        public SiteimproveResponse<SiteimproveSiteSummary> GetSites(int page, int pageSize) {
            return SiteimproveHelpers.ParseResponse(Raw.GetSites(page, pageSize), SiteimproveSiteSummary.Parse);
        }

        #endregion

    }

}