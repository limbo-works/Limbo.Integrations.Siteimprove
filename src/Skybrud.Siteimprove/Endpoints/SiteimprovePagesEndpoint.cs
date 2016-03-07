using Skybrud.Siteimprove.Endpoints.Raw;
using Skybrud.Siteimprove.Options.Pages;
using Skybrud.Siteimprove.Responses.Pages;

namespace Skybrud.Siteimprove.Endpoints {

    public class SiteimprovePagesEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; private set; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimprovePagesRawEndpoint Raw {
            get { return Service.Client.Pages; }
        }

        #endregion

        #region Constructors

        internal SiteimprovePagesEndpoint(SiteimproveService service) {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets detailed information about a page with the specified <code>pageId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveGetPageResponse"/> representing the response.</returns>
        public SiteimproveGetPageResponse GetPage(int siteId, long pageId) {
            return SiteimproveGetPageResponse.ParseResponse(Raw.GetPage(siteId, pageId));
        }

        /// <summary>
        /// Gets a list of all pages for a site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveGetPagesResponse"/> representing the response.</returns>
        public SiteimproveGetPagesResponse GetPages(int siteId) {
            return SiteimproveGetPagesResponse.ParseResponse(Raw.GetPages(siteId));
        }

        /// <summary>
        /// Gets a list of all pages for a site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page to retrieve.</param>
        /// <param name="pageSize">The number of item on each page.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveGetPagesResponse"/> representing the response.</returns>
        public SiteimproveGetPagesResponse GetPages(int siteId, int page, int pageSize) {
            return SiteimproveGetPagesResponse.ParseResponse(Raw.GetPages(siteId, page, pageSize));
        }

        /// <summary>
        /// Gets a list of all pages for a site matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveGetPagesResponse"/> representing the response.</returns>
        public SiteimproveGetPagesResponse GetPages(SiteimproveGetPagesOptions options) {
            return SiteimproveGetPagesResponse.ParseResponse(Raw.GetPages(options));
        }

        #endregion

    }

}