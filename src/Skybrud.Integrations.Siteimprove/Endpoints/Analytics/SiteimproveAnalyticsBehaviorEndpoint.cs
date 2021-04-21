using Skybrud.Integrations.Siteimprove.Endpoints.Analytics.Raw;
using Skybrud.Integrations.Siteimprove.Options.Analytics;
using Skybrud.Integrations.Siteimprove.Responses.Analytics.Behavior;

namespace Skybrud.Integrations.Siteimprove.Endpoints.Analytics {

    public class SiteimproveAnalyticsBehaviorEndpoint {

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
        public SiteimproveAnalyticsBehaviorRawEndpoint Raw {
            get { return Service.Client.Analytics.Behavior; }
        }

        #endregion

        #region Constructors

        internal SiteimproveAnalyticsBehaviorEndpoint(SiteimproveService service, SiteimproveAnalyticsEndpoint analytics) {
            Service = service;
            Analytics = analytics;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list with historical data for the average duration a user spends on the site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsVisitLengthResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsVisitLengthResponse GetVisitLengthHistory(int siteId) {
            return SiteimproveAnalyticsVisitLengthResponse.ParseResponse(Raw.GetVisitLengthHistory(siteId));
        }

        /// <summary>
        /// Gets a list with historical data for the average duration a user spends on the site matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsVisitLengthResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsVisitLengthResponse GetVisitLengthHistory(SiteimproveAnalyticsGetPeriodOptions options) {
            return SiteimproveAnalyticsVisitLengthResponse.ParseResponse(Raw.GetVisitLengthHistory(options));
        }

        #endregion

    }

}