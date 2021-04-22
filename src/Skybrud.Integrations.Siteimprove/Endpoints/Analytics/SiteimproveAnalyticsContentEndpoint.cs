using Skybrud.Integrations.Siteimprove.Options.Analytics.Content;
using Skybrud.Integrations.Siteimprove.Responses.Analytics.Content;

namespace Skybrud.Integrations.Siteimprove.Endpoints.Analytics {

    public class SiteimproveAnalyticsContentEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; }

        /// <summary>
        /// Gets a reference to the parent Analytics service.
        /// </summary>
        public SiteimproveAnalyticsEndpoint Analytics { get; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveAnalyticsContentRawEndpoint Raw => Service.Client.Analytics.Content;

        #endregion

        #region Constructors

        internal SiteimproveAnalyticsContentEndpoint(SiteimproveService service, SiteimproveAnalyticsEndpoint analytics) {
            Service = service;
            Analytics = analytics;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of the least popular pages for the site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsPopularPageListResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsPopularPageListResponse GetLeastPopularPages(int siteId) {
            return new SiteimproveAnalyticsPopularPageListResponse(Raw.GetLeastPopularPages(siteId));
        }

        /// <summary>
        /// Gets a list of the least popular pages for the site and pages matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsPopularPageListResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsPopularPageListResponse GetLeastPopularPages(SiteimproveGetLeastPopularPagesOptions options) {
            return new SiteimproveAnalyticsPopularPageListResponse(Raw.GetLeastPopularPages(options));
        }

        /// <summary>
        /// Gets a list of the most popular pages for the site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsPopularPageListResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsPopularPageListResponse GetMostPopularPages(int siteId) {
            return new SiteimproveAnalyticsPopularPageListResponse(Raw.GetMostPopularPages(siteId));
        }

        /// <summary>
        /// Gets a list of the most popular pages for the site and pages matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsPopularPageListResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsPopularPageListResponse GetMostPopularPages(SiteimproveGetMostPopularPagesOptions options) {
            return new SiteimproveAnalyticsPopularPageListResponse(Raw.GetMostPopularPages(options));
        }

        /// <summary>
        /// Gets a list of all content pages for the site with the specified <code>siteId</code>. 
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsPageListResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsPageListResponse GetAllPages(int siteId) {
            return new SiteimproveAnalyticsPageListResponse(Raw.GetAllPages(siteId));
        }

        /// <summary>
        /// Gets a list of all content pages for the site matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsPageListResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsPageListResponse GetAllPages(SiteimproveAnalyticsGetAllPagesOptions options) {
            return new SiteimproveAnalyticsPageListResponse(Raw.GetAllPages(options));
        }

        #endregion

    }

}