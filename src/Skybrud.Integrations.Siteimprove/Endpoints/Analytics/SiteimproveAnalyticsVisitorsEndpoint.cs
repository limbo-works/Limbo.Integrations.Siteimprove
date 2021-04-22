using Skybrud.Integrations.Siteimprove.Options.Analytics.Visitors;
using Skybrud.Integrations.Siteimprove.Responses.Analytics.Visitors;

namespace Skybrud.Integrations.Siteimprove.Endpoints.Analytics {

    public class SiteimproveAnalyticsVisitorsEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the parent Analytics service.
        /// </summary>
        public SiteimproveAnalyticsEndpoint Analytics { get; private set; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveAnalyticsVisitorsRawEndpoint Raw {
            get { return Service.Client.Analytics.Visitors; }
        }

        #endregion

        #region Constructors

        internal SiteimproveAnalyticsVisitorsEndpoint(SiteimproveService service, SiteimproveAnalyticsEndpoint analytics) {
            Service = service;
            Analytics = analytics;
        }

        #endregion

        #region Member methods

        public SiteimproveGetDevicesResponse GetDevices(int siteId) {
            return SiteimproveGetDevicesResponse.ParseResponse(Raw.GetDevices(siteId));
        }

        public SiteimproveGetDevicesResponse GetDevices(int siteId, int page, int pageSize, string period) {
            return SiteimproveGetDevicesResponse.ParseResponse(Raw.GetDevices(siteId, page, pageSize, period));
        }

        public SiteimproveGetDevicesResponse GetDevices(int siteId, int page, int pageSize, int groupId, int filterId, string period) {
            return SiteimproveGetDevicesResponse.ParseResponse(Raw.GetDevices(siteId, page, pageSize, groupId, filterId, period));
        }

        public SiteimproveGetDevicesResponse GetDevices(SiteimproveGetDevicesOptions options) {
            return SiteimproveGetDevicesResponse.ParseResponse(Raw.GetDevices(options));
        }

        #endregion

    }

}