using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Endpoints.Raw {

    public class SiteimproveSpellingRawEndpoint {

        #region Properties

        public SiteimproveClient Client { get; private set; }

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
        public SocialHttpResponse GetOverview(int siteId) {
            return GetOverview(siteId, 0, 0);
        }

        /// <summary>
        /// Gets a overview for misspellings and potential misspellings.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageSize">The maximum amount of items that should be returned on each page.</param>
        public SocialHttpResponse GetOverview(int siteId, int pageSize) {
            return GetOverview(siteId, 0, pageSize);
        }

        /// <summary>
        /// Gets a overview for misspellings and potential misspellings.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page that should be returned.</param>
        /// <param name="pageSize">The maximum amount of items that should be returned on each page.</param>
        public SocialHttpResponse GetOverview(int siteId, int page, int pageSize) {
            SocialQueryString query = new SocialQueryString();
            if (page > 0) query.Add("page", page);
            if (pageSize > 0) query.Add("page_size", pageSize);
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrl + "sites/" + siteId + "/quality_assurance/spelling", query);
        }

        #endregion

    }

}