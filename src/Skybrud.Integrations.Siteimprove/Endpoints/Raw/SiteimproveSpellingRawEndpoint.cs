using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;

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

        #endregion

    }

}