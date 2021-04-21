using Skybrud.Integrations.Siteimprove.Endpoints.Analytics.Raw;
using Skybrud.Integrations.Siteimprove.Options.Analytics.Content;
using Skybrud.Integrations.Siteimprove.Responses.Analytics.Content;

namespace Skybrud.Integrations.Siteimprove.Endpoints.Analytics {

    public class SiteimproveAnalyticsContentEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the parent Analytics service.
        /// </summary>
        public SiteimproveAnalyticsEndpoint Analytics { get; private set; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveAnalyticsContentRawEndpoint Raw {
            get { return Service.Client.Analytics.Content; }
        }

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
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsGetPopularPagesResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsGetPopularPagesResponse GetLeastPopularPages(int siteId) {
            return SiteimproveAnalyticsGetPopularPagesResponse.ParseResponse(Raw.GetLeastPopularPages(siteId));
        }

        /// <summary>
        /// Gets a list of the least popular pages for the site and pages matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsGetPopularPagesResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsGetPopularPagesResponse GetLeastPopularPages(SiteimproveGetLeastPopularPagesOptions options) {
            return SiteimproveAnalyticsGetPopularPagesResponse.ParseResponse(Raw.GetLeastPopularPages(options));
        }

        /// <summary>
        /// Gets a list of the most popular pages for the site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsGetPopularPagesResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsGetPopularPagesResponse GetMostPopularPages(int siteId) {
            return SiteimproveAnalyticsGetPopularPagesResponse.ParseResponse(Raw.GetMostPopularPages(siteId));
        }

        /// <summary>
        /// Gets a list of the most popular pages for the site and pages matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsGetPopularPagesResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsGetPopularPagesResponse GetMostPopularPages(SiteimproveGetMostPopularPagesOptions options) {
            return SiteimproveAnalyticsGetPopularPagesResponse.ParseResponse(Raw.GetMostPopularPages(options));
        }

        /// <summary>
        /// Gets a list of all content pages for the site with the specified <code>siteId</code>. 
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveGetAllPagesResponse"/> representing the response.</returns>
        public SiteimproveGetAllPagesResponse GetAllPages(int siteId) {
            return SiteimproveGetAllPagesResponse.ParseResponse(Raw.GetAllPages(siteId));
        }

        /// <summary>
        /// Gets a list of all content pages for the site matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveGetAllPagesResponse"/> representing the response.</returns>
        public SiteimproveGetAllPagesResponse GetAllPages(SiteimproveAnalyticsGetAllPagesOptions options) {
            return SiteimproveGetAllPagesResponse.ParseResponse(Raw.GetAllPages(options));
        }

        #endregion

    }

}