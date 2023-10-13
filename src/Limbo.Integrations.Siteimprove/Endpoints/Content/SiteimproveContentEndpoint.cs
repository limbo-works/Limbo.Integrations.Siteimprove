using Limbo.Integrations.Siteimprove.Options.Content;
using Limbo.Integrations.Siteimprove.Responses.Pages;

namespace Limbo.Integrations.Siteimprove.Endpoints.Content {

    public class SiteimproveContentEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveHttpService Service { get; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveContentRawEndpoint Raw => Service.Client.Content;

        #endregion

        #region Constructors

        internal SiteimproveContentEndpoint(SiteimproveHttpService service) {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets detailed information about a page with the specified <paramref name="pageId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <returns>An instance of <see cref="SiteimprovePageResponse"/> representing the response.</returns>
        public SiteimprovePageResponse GetPage(long siteId, long pageId) {
            return new SiteimprovePageResponse(Raw.GetPage(siteId, pageId));
        }

        /// <summary>
        /// Gets a list of all pages for a site with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>An instance of <see cref="SiteimprovePageListResponse"/> representing the response.</returns>
        public SiteimprovePageListResponse GetPages(long siteId) {
            return new SiteimprovePageListResponse(Raw.GetPages(siteId));
        }

        /// <summary>
        /// Gets a list of all pages for a site with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page to retrieve.</param>
        /// <param name="pageSize">The number of item on each page.</param>
        /// <returns>An instance of <see cref="SiteimprovePageListResponse"/> representing the response.</returns>
        public SiteimprovePageListResponse GetPages(long siteId, int page, int pageSize) {
            return new SiteimprovePageListResponse(Raw.GetPages(siteId, page, pageSize));
        }

        /// <summary>
        /// Gets a list of all pages for a site matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SiteimprovePageListResponse"/> representing the response.</returns>
        public SiteimprovePageListResponse GetPages(SiteimproveGetPagesOptions options) {
            return new SiteimprovePageListResponse(Raw.GetPages(options));
        }

        #endregion

    }

}