using System;
using Skybrud.Essentials.Common;
using Skybrud.Integrations.Siteimprove.Options.Content;
using Skybrud.Social.Http;

namespace Skybrud.Integrations.Siteimprove.Endpoints.Raw {

    public class SiteimproveContentRawEndpoint {

        #region Properties

        public SiteimproveClient Client { get; }

        #endregion

        #region Constructor

        internal SiteimproveContentRawEndpoint(SiteimproveClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets detailed information about a page with the specified <paramref name="pageId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Content/get_sites_site_id_content_pages_page_id</cref>
        /// </see>
        public SocialHttpResponse GetPage(long siteId, long pageId) {
            if (siteId <= 0) throw new ArgumentException("Argument siteId must be specified", "siteId");
            if (pageId <= 0) throw new ArgumentException("Argument pageId must be specified", "pageId");
            return Client.DoHttpGetRequest($"/v2/sites/{siteId}/content/pages/{pageId}");
        }

        /// <summary>
        /// Gets a list of all pages for a site with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Content/get_sites_site_id_content_pages</cref>
        /// </see>
        public SocialHttpResponse GetPages(long siteId) {
            return GetPages(siteId, 0, 0);
        }

        /// <summary>
        /// Gets a list of all pages for a site with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page to retrieve.</param>
        /// <param name="pageSize">The number of item on each page.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Content/get_sites_site_id_content_pages</cref>
        /// </see>
        public SocialHttpResponse GetPages(long siteId, int page, int pageSize) {
            return GetPages(new SiteimproveGetPagesOptions {
                SiteId = siteId,
                Page = page,
                PageSize = pageSize
            });
        }

        /// <summary>
        /// Gets a list of all pages for a site matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Content/get_sites_site_id_content_pages</cref>
        /// </see>
        public SocialHttpResponse GetPages(SiteimproveGetPagesOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (options.SiteId <= 0) throw new PropertyNotSetException(nameof(options.SiteId));
            return Client.DoHttpGetRequest($"/v2/sites/{options.SiteId}/content/pages", options);
        }

        #endregion

    }

}