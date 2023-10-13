using Limbo.Integrations.Siteimprove.Options.Analytics.Overview;
using Limbo.Integrations.Siteimprove.Responses.Analytics.Overview;

namespace Limbo.Integrations.Siteimprove.Endpoints.Analytics {

    public class SiteimproveAnalyticsOverviewEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Siteimprove service.
        /// </summary>
        public SiteimproveHttpService Service { get; }

        /// <summary>
        /// Gets a reference to the parent Analytics service.
        /// </summary>
        public SiteimproveAnalyticsEndpoint Analytics { get; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveAnalyticsOverviewRawEndpoint Raw => Service.Client.Analytics.Overview;

        #endregion

        #region Constructors

        internal SiteimproveAnalyticsOverviewEndpoint(SiteimproveHttpService service, SiteimproveAnalyticsEndpoint analytics) {
            Service = service;
            Analytics = analytics;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of historical data points showing the most common statistics for the site with specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsHistoryResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsHistoryResponse GetHistory(long siteId) {
            return new SiteimproveAnalyticsHistoryResponse(Raw.GetHistory(siteId));
        }

        /// <summary>
        /// Gets a list of historical data points showing the most common statistics for the matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsHistoryResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsHistoryResponse GetHistory(SiteimproveGetHistoryOptions options) {
            return new SiteimproveAnalyticsHistoryResponse(Raw.GetHistory(options));
        }

        /// <summary>
        /// Gets a summary with the most common statistics for the site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsSummaryResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsSummaryResponse GetSummary(long siteId) {
            return new SiteimproveAnalyticsSummaryResponse(Raw.GetSummary(siteId));
        }

        /// <summary>
        /// Gets a summary with the most common statistics for the site matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsSummaryResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsSummaryResponse GetSummary(SiteimproveGetSummaryOverviewOptions options) {
            return new SiteimproveAnalyticsSummaryResponse(Raw.GetSummary(options));
        }

        #endregion

    }

}