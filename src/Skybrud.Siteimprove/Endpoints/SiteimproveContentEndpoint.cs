using Skybrud.Siteimprove.Endpoints.Raw;
using Skybrud.Siteimprove.Options.Content;
using Skybrud.Siteimprove.Responses.Pages;

namespace Skybrud.Siteimprove.Endpoints {

    public class SiteimproveContentEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveContentRawEndpoint Raw => Service.Client.Content;

        #endregion

        #region Constructors

        internal SiteimproveContentEndpoint(SiteimproveService service) {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets detailed information about a page with the specified <paramref name="pageId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <returns>An instance of <see cref="SiteimproveGetPageResponse"/> representing the response.</returns>
        public SiteimproveGetPageResponse GetPage(long siteId, long pageId) {
            return SiteimproveGetPageResponse.ParseResponse(Raw.GetPage(siteId, pageId));
        }

        /// <summary>
        /// Gets a list of all pages for a site with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>An instance of <see cref="SiteimproveGetPagesResponse"/> representing the response.</returns>
        public SiteimproveGetPagesResponse GetPages(long siteId) {
            return SiteimproveGetPagesResponse.ParseResponse(Raw.GetPages(siteId));
        }

        /// <summary>
        /// Gets a list of all pages for a site with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page to retrieve.</param>
        /// <param name="pageSize">The number of item on each page.</param>
        /// <returns>An instance of <see cref="SiteimproveGetPagesResponse"/> representing the response.</returns>
        public SiteimproveGetPagesResponse GetPages(long siteId, int page, int pageSize) {
            return SiteimproveGetPagesResponse.ParseResponse(Raw.GetPages(siteId, page, pageSize));
        }

        /// <summary>
        /// Gets a list of all pages for a site matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SiteimproveGetPagesResponse"/> representing the response.</returns>
        public SiteimproveGetPagesResponse GetPages(SiteimproveGetPagesOptions options) {
            return SiteimproveGetPagesResponse.ParseResponse(Raw.GetPages(options));
        }

        #endregion

    }

}