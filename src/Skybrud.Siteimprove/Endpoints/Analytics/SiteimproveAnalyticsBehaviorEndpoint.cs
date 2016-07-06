using Skybrud.Siteimprove.Endpoints.Analytics.Raw;

namespace Skybrud.Siteimprove.Endpoints.Analytics {

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
        public SiteimproveAnalyticsContentRawEndpoint Raw {
            get { return Service.Client.Analytics.Content; }
        }

        #endregion

        #region Constructors

        internal SiteimproveAnalyticsBehaviorEndpoint(SiteimproveService service, SiteimproveAnalyticsEndpoint analytics) {
            Service = service;
            Analytics = analytics;
        }

        #endregion

        #region Member methods

        #endregion

    }

}