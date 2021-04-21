using Skybrud.Social.Http;

namespace Skybrud.Integrations.Siteimprove.Endpoints.Raw {

    public class SiteimproveBrokenLinksRawEndpoint {

        #region Properties

        public SiteimproveClient Client { get; }

        #endregion

        #region Constructor

        internal SiteimproveBrokenLinksRawEndpoint(SiteimproveClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a overview for broken links.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Quality_Assurance/get_sites_site_id_quality_assurance_links_broken_links</cref>
        /// </see>
        public SocialHttpResponse GetOverview(int siteId) {
            return GetOverview(siteId, 0, 0);
        }

        /// <summary>
        /// Gets a overview for broken links.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageSize">The maximum amount of items that should be returned on each page.</param>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Quality_Assurance/get_sites_site_id_quality_assurance_links_broken_links</cref>
        /// </see>
        public SocialHttpResponse GetOverview(int siteId, int pageSize) {
            return GetOverview(siteId, 0, pageSize);
        }

        /// <summary>
        /// Gets a overview for broken links.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page that should be returned.</param>
        /// <param name="pageSize">The maximum amount of items that should be returned on each page.</param>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Quality_Assurance/get_sites_site_id_quality_assurance_links_broken_links</cref>
        /// </see>
        public SocialHttpResponse GetOverview(int siteId, int page, int pageSize) {
            SocialQueryString query = new SocialQueryString();
            if (page > 0) query.Add("page", page);
            if (pageSize > 0) query.Add("page_size", pageSize);
            return Client.DoHttpGetRequest($"/v2/sites/{siteId}/quality_assurance/links/broken_links", query);
        }

        /// <summary>
        /// Gets a list of pages with broken links.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        public SocialHttpResponse GetPages(int siteId) {
            return Client.DoHttpGetRequest($"/v2/sites/{siteId}/quality_assurance/broken_links/pages");
        }

        /// <summary>
        /// Gets a list of broken links on the site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        public SocialHttpResponse GetLinks(int siteId) {
            return Client.DoHttpGetRequest($"/v2/sites/{siteId}/quality_assurance/broken_links/links");
        }

        /// <summary>
        /// Gets a list of pages for a broken link.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="linkId">The ID of the link.</param>
        public SocialHttpResponse GetPagesFromLink(int siteId, int linkId) {
            return Client.DoHttpGetRequest($"/v2/sites/{siteId}/quality_assurance/broken_links/links/" + linkId + "/pages");
        }

        /// <summary>
        /// Geta a list of broken links on a page.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageId">The ID of the page.</param>
        public SocialHttpResponse GetLinksFromPage(int siteId, int pageId) {
            return Client.DoHttpGetRequest($"/v2/sites/{siteId}/quality_assurance/broken_links/links");
        }

        #endregion

    }

}