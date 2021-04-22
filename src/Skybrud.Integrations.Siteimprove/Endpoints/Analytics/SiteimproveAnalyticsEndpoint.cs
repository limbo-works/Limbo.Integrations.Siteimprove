namespace Skybrud.Integrations.Siteimprove.Endpoints.Analytics {

    public class SiteimproveAnalyticsEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveAnalyticsRawEndpoint Raw => Service.Client.Analytics;

        public SiteimproveAnalyticsBehaviorEndpoint Behavior { get; }

        public SiteimproveAnalyticsContentEndpoint Content { get; }

        public SiteimproveAnalyticsOverviewEndpoint Overview { get; }

        public SiteimproveAnalyticsVisitorsEndpoint Visitors { get; }

        #endregion

        #region Constructors

        internal SiteimproveAnalyticsEndpoint(SiteimproveService service) {
            Service = service;
            Behavior = new SiteimproveAnalyticsBehaviorEndpoint(service, this);
            Content = new SiteimproveAnalyticsContentEndpoint(service, this);
            Overview = new SiteimproveAnalyticsOverviewEndpoint(service, this);
            Visitors = new SiteimproveAnalyticsVisitorsEndpoint(service, this);
        }

        #endregion

    }

}