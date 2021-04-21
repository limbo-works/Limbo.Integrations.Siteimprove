using Skybrud.Integrations.Siteimprove.Endpoints.Raw;
using Skybrud.Integrations.Siteimprove.Models.QualityAssurance.Spelling.Overview;
using Skybrud.Integrations.Siteimprove.Responses;
using Skybrud.Integrations.Siteimprove.Responses.QualityAssurance.Spelling;

namespace Skybrud.Integrations.Siteimprove.Endpoints {

    public class SiteimproveSpellingEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveSpellingRawEndpoint Raw => Service.Client.QualityAssurance.Spelling;

        #endregion

        #region Constructors

        internal SiteimproveSpellingEndpoint(SiteimproveService service) {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a overview for misspellings and potential misspellings.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        public SiteimproveResponse<SpellingCollection> GetOverview(int siteId) {
            return GetOverview(siteId, 0, 0);
        }

        /// <summary>
        /// Gets a overview for misspellings and potential misspellings.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageSize">The maximum amount of items that should be returned on each page.</param>
        public SiteimproveResponse<SpellingCollection> GetOverview(int siteId, int pageSize) {
            return GetOverview(siteId, 0, pageSize);
        }

        /// <summary>
        /// Gets a overview for misspellings and potential misspellings.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page that should be returned.</param>
        /// <param name="pageSize">The maximum amount of items that should be returned on each page.</param>
        public SiteimproveResponse<SpellingCollection> GetOverview(int siteId, int page, int pageSize) {
            return SiteimproveGetSpellingResponse.ParseResponse(Raw.GetOverview(siteId, page, pageSize));
        }

        #endregion

    }

}