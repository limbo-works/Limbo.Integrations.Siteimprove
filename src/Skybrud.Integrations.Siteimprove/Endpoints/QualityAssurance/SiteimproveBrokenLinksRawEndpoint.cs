using System;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Integrations.Siteimprove.Options.QualityAssurance.BrokenLinks;

namespace Skybrud.Integrations.Siteimprove.Endpoints.QualityAssurance {

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
        public IHttpResponse GetOverview(int siteId) {
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
        public IHttpResponse GetOverview(int siteId, int pageSize) {
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
        public IHttpResponse GetOverview(int siteId, int page, int pageSize) {
            IHttpQueryString query = new HttpQueryString();
            if (page > 0) query.Add("page", page);
            if (pageSize > 0) query.Add("page_size", pageSize);
            return Client.Get($"/v2/sites/{siteId}/quality_assurance/links/broken_links", query);
        }

        /// <summary>
        /// Gets a list of pages with broken links.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Quality_Assurance/get_sites_site_id_quality_assurance_links_pages_with_broken_links</cref>
        /// </see>
        public IHttpResponse GetPagesWithBrokenLinks(int siteId) {
            return GetPagesWithBrokenLinks(new SiteimproveGetPagesWithBrokenLinksOptions(siteId));
        }

        /// <summary>
        /// Gets a list of pages with broken links.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page that should be returned.</param>
        /// <param name="pageSize">The maximum amount of items per page.</param>
        /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Quality_Assurance/get_sites_site_id_quality_assurance_links_pages_with_broken_links</cref>
        /// </see>
        public IHttpResponse GetPagesWithBrokenLinks(int siteId, int page, int pageSize) {
            return GetPagesWithBrokenLinks(new SiteimproveGetPagesWithBrokenLinksOptions(siteId, page, pageSize));
        }

        /// <summary>
        /// Gets a list of pages with broken links.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Quality_Assurance/get_sites_site_id_quality_assurance_links_pages_with_broken_links</cref>
        /// </see>
        public IHttpResponse GetPagesWithBrokenLinks(SiteimproveGetPagesWithBrokenLinksOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }
        
        /// <summary>
        /// Gets a list of broken links on the site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        public IHttpResponse GetLinks(int siteId) {
            return Client.Get($"/v2/sites/{siteId}/quality_assurance/broken_links/links");
        }

        /// <summary>
        /// Gets a list of pages for a broken link.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="linkId">The ID of the link.</param>
        public IHttpResponse GetPagesFromLink(int siteId, int linkId) {
            return Client.Get($"/v2/sites/{siteId}/quality_assurance/broken_links/links/" + linkId + "/pages");
        }

        /// <summary>
        /// Geta a list of broken links on a page.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageId">The ID of the page.</param>
        public IHttpResponse GetLinksFromPage(int siteId, int pageId) {
            return Client.Get($"/v2/sites/{siteId}/quality_assurance/broken_links/links");
        }

        #endregion

    }

}