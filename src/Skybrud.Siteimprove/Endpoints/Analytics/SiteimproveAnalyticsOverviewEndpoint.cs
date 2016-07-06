using Skybrud.Siteimprove.Endpoints.Analytics.Raw;
using Skybrud.Siteimprove.Options.Analytics;
using Skybrud.Siteimprove.Responses.Analytics.Overview;

namespace Skybrud.Siteimprove.Endpoints.Analytics {

    public class SiteimproveAnalyticsOverviewEndpoint {

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
        public SiteimproveAnalyticsOverviewRawEndpoint Raw {
            get { return Service.Client.Analytics.Overview; }
        }

        #endregion

        #region Constructors

        internal SiteimproveAnalyticsOverviewEndpoint(SiteimproveService service, SiteimproveAnalyticsEndpoint analytics) {
            Service = service;
            Analytics = analytics;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of historical data points showing the most common statistics for the site with specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsGetHistoryResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsGetHistoryResponse GetHistory(int siteId) {
            return SiteimproveAnalyticsGetHistoryResponse.ParseResponse(Raw.GetHistory(siteId));
        }

        /// <summary>
        /// Gets a list of historical data points showing the most common statistics for the matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsGetHistoryResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsGetHistoryResponse GetHistory(SiteimproveAnalyticsGetPeriodOptions options) {
            return SiteimproveAnalyticsGetHistoryResponse.ParseResponse(Raw.GetHistory(options));
        }

        #endregion

    }

}