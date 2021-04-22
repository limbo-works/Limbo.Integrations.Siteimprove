using System;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Integrations.Siteimprove.Options.QualityAssurance.Spelling;

namespace Skybrud.Integrations.Siteimprove.Endpoints.Raw {

    public class SiteimproveSpellingRawEndpoint {

        #region Properties

        public SiteimproveClient Client { get; }

        #endregion

        #region Constructor

        internal SiteimproveSpellingRawEndpoint(SiteimproveClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a overview for misspellings and potential misspellings.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        public IHttpResponse GetOverview(int siteId) {
            return GetOverview(siteId, 0, 0);
        }

        /// <summary>
        /// Gets a overview for misspellings and potential misspellings.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageSize">The maximum amount of items that should be returned on each page.</param>
        public IHttpResponse GetOverview(int siteId, int pageSize) {
            return GetOverview(siteId, 0, pageSize);
        }

        /// <summary>
        /// Gets a overview for misspellings and potential misspellings.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page that should be returned.</param>
        /// <param name="pageSize">The maximum amount of items that should be returned on each page.</param>
        public IHttpResponse GetOverview(int siteId, int page, int pageSize) {
            IHttpQueryString query = new HttpQueryString();
            if (page > 0) query.Add("page", page);
            if (pageSize > 0) query.Add("page_size", pageSize);
            return Client.Get($"/v2/sites/{siteId}/quality_assurance/spelling/history", query);
        }

        /// <summary>
        /// Gets a list of pages with misspellings and/or potential misspellings.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Quality_Assurance/get_sites_site_id_quality_assurance_spelling_pages</cref>
        /// </see>
        public IHttpResponse GetPages(int siteId) {
            return GetPages(new SiteimproveGetPagesWithSpellingErrorsOptions(siteId));
        }

        /// <summary>
        /// Gets a list of pages with misspellings and/or potential misspellings.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page that should be returned.</param>
        /// <param name="pageSize">The maximum amount of items per page.</param>
        /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Quality_Assurance/get_sites_site_id_quality_assurance_spelling_pages</cref>
        /// </see>
        public IHttpResponse GetPages(int siteId, int page, int pageSize) {
            return GetPages(new SiteimproveGetPagesWithSpellingErrorsOptions(siteId, page, pageSize));
        }

        /// <summary>
        /// Gets a list of pages with misspellings and/or potential misspellings.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Quality_Assurance/get_sites_site_id_quality_assurance_spelling_pages</cref>
        /// </see>
        public IHttpResponse GetPages(SiteimproveGetPagesWithSpellingErrorsOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        #endregion

    }

}