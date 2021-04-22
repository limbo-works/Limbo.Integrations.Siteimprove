using Skybrud.Integrations.Siteimprove.Models.QualityAssurance.Spelling.Overview;
using Skybrud.Integrations.Siteimprove.Options.QualityAssurance.Spelling;
using Skybrud.Integrations.Siteimprove.Responses;
using Skybrud.Integrations.Siteimprove.Responses.QualityAssurance.Spelling;

namespace Skybrud.Integrations.Siteimprove.Endpoints.QualityAssurance {

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

        /// <summary>
        /// Gets a list of pages with misspellings and/or potential misspellings.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="SiteimprovePageWithSpellingErrorsListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Quality_Assurance/get_sites_site_id_quality_assurance_spelling_pages</cref>
        /// </see>
        public SiteimprovePageWithSpellingErrorsListResponse GetPages(int siteId) {
            return new SiteimprovePageWithSpellingErrorsListResponse(Raw.GetPages(siteId));
        }

        /// <summary>
        /// Gets a list of pages with misspellings and/or potential misspellings.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page that should be returned.</param>
        /// <param name="pageSize">The maximum amount of items per page.</param>
        /// <returns>Returns an instance of <see cref="SiteimprovePageWithSpellingErrorsListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Quality_Assurance/get_sites_site_id_quality_assurance_spelling_pages</cref>
        /// </see>
        public SiteimprovePageWithSpellingErrorsListResponse GetPages(int siteId, int page, int pageSize) {
            return new SiteimprovePageWithSpellingErrorsListResponse(Raw.GetPages(siteId, page, pageSize));
        }

        /// <summary>
        /// Gets a list of pages with misspellings and/or potential misspellings.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SiteimprovePageWithSpellingErrorsListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Quality_Assurance/get_sites_site_id_quality_assurance_spelling_pages</cref>
        /// </see>
        public SiteimprovePageWithSpellingErrorsListResponse GetPages(SiteimproveGetPagesWithSpellingErrorsOptions options) {
            return new SiteimprovePageWithSpellingErrorsListResponse(Raw.GetPages(options));
        }

        #endregion

    }

}