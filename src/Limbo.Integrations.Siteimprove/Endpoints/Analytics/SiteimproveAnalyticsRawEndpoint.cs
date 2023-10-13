using Limbo.Integrations.Siteimprove.Http;

namespace Limbo.Integrations.Siteimprove.Endpoints.Analytics {
    
    public class SiteimproveAnalyticsRawEndpoint {

        #region Properties

        public SiteimproveHttpClient Client { get; }

        public SiteimproveAnalyticsBehaviorRawEndpoint Behavior { get; }

        public SiteimproveAnalyticsContentRawEndpoint Content { get; }

        public SiteimproveAnalyticsOverviewRawEndpoint Overview { get; }

        public SiteimproveAnalyticsVisitorsRawEndpoint Visitors { get; }

        #endregion

        #region Constructor

        internal SiteimproveAnalyticsRawEndpoint(SiteimproveHttpClient client) {
            Client = client;
            Behavior = new SiteimproveAnalyticsBehaviorRawEndpoint(client, this);
            Content = new SiteimproveAnalyticsContentRawEndpoint(client, this);
            Overview = new SiteimproveAnalyticsOverviewRawEndpoint(client, this);
            Visitors = new SiteimproveAnalyticsVisitorsRawEndpoint(client, this);
        }

        #endregion

    }

}