namespace Skybrud.Integrations.Siteimprove.Endpoints.Analytics {
    
    public class SiteimproveAnalyticsRawEndpoint {

        #region Properties

        public SiteimproveClient Client { get; private set; }

        public SiteimproveAnalyticsBehaviorRawEndpoint Behavior { get; private set; }

        public SiteimproveAnalyticsContentRawEndpoint Content { get; private set; }

        public SiteimproveAnalyticsOverviewRawEndpoint Overview { get; private set; }

        public SiteimproveAnalyticsVisitorsRawEndpoint Visitors { get; private set; }

        #endregion

        #region Constructor

        internal SiteimproveAnalyticsRawEndpoint(SiteimproveClient client) {
            Client = client;
            Behavior = new SiteimproveAnalyticsBehaviorRawEndpoint(client, this);
            Content = new SiteimproveAnalyticsContentRawEndpoint(client, this);
            Overview = new SiteimproveAnalyticsOverviewRawEndpoint(client, this);
            Visitors = new SiteimproveAnalyticsVisitorsRawEndpoint(client, this);
        }

        #endregion

    }

}