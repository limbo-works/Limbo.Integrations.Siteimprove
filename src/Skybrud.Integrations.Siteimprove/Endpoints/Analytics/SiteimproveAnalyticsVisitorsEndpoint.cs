using Skybrud.Integrations.Siteimprove.Options.Analytics.Visitors;
using Skybrud.Integrations.Siteimprove.Responses.Analytics.Visitors;

namespace Skybrud.Integrations.Siteimprove.Endpoints.Analytics {

    public class SiteimproveAnalyticsVisitorsEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; }

        /// <summary>
        /// Gets a reference to the parent Analytics service.
        /// </summary>
        public SiteimproveAnalyticsEndpoint Analytics { get; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveAnalyticsVisitorsRawEndpoint Raw => Service.Client.Analytics.Visitors;

        #endregion

        #region Constructors

        internal SiteimproveAnalyticsVisitorsEndpoint(SiteimproveService service, SiteimproveAnalyticsEndpoint analytics) {
            Service = service;
            Analytics = analytics;
        }

        #endregion

        #region Member methods

        public SiteimproveAnalyticsDeviceListResponse GetDevices(int siteId) {
            return new SiteimproveAnalyticsDeviceListResponse(Raw.GetDevices(siteId));
        }

        public SiteimproveAnalyticsDeviceListResponse GetDevices(int siteId, int page, int pageSize, string period) {
            return new SiteimproveAnalyticsDeviceListResponse(Raw.GetDevices(siteId, page, pageSize, period));
        }

        public SiteimproveAnalyticsDeviceListResponse GetDevices(int siteId, int page, int pageSize, int groupId, int filterId, string period) {
            return new SiteimproveAnalyticsDeviceListResponse(Raw.GetDevices(siteId, page, pageSize, groupId, filterId, period));
        }

        public SiteimproveAnalyticsDeviceListResponse GetDevices(SiteimproveGetDevicesOptions options) {
            return new SiteimproveAnalyticsDeviceListResponse(Raw.GetDevices(options));
        }

        #endregion

    }

}