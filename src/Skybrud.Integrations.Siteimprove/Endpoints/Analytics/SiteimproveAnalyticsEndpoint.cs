namespace Skybrud.Integrations.Siteimprove.Endpoints.Analytics {

    public class SiteimproveAnalyticsEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; private set; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveAnalyticsRawEndpoint Raw {
            get { return Service.Client.Analytics; }
        }

        public SiteimproveAnalyticsBehaviorEndpoint Behavior { get; private set; }

        public SiteimproveAnalyticsContentEndpoint Content { get; private set; }

        public SiteimproveAnalyticsOverviewEndpoint Overview { get; private set; }

        public SiteimproveAnalyticsVisitorsEndpoint Visitors { get; private set; }

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