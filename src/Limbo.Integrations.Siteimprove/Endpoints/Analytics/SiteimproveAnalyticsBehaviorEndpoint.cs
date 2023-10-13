using Limbo.Integrations.Siteimprove.Options.Analytics.Behavior;
using Limbo.Integrations.Siteimprove.Responses.Analytics.Behavior;

namespace Limbo.Integrations.Siteimprove.Endpoints.Analytics {

    public class SiteimproveAnalyticsBehaviorEndpoint {

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
        public SiteimproveAnalyticsBehaviorRawEndpoint Raw => Service.Client.Analytics.Behavior;

        #endregion

        #region Constructors

        internal SiteimproveAnalyticsBehaviorEndpoint(SiteimproveHttpService service, SiteimproveAnalyticsEndpoint analytics) {
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
        public SiteimproveAnalyticsVisitLengthResponse GetVisitLengthHistory(long siteId) {
            return new SiteimproveAnalyticsVisitLengthResponse(Raw.GetVisitLengthHistory(siteId));
        }

        /// <summary>
        /// Gets a list with historical data for the average duration a user spends on the site matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsVisitLengthResponse"/> representing the response.</returns>
        public SiteimproveAnalyticsVisitLengthResponse GetVisitLengthHistory(SiteimproveGetVisitLengthHistoryOptions options) {
            return new SiteimproveAnalyticsVisitLengthResponse(Raw.GetVisitLengthHistory(options));
        }

        #endregion

    }

}