using System;
using Skybrud.Essentials.Http;
using Skybrud.Integrations.Siteimprove.Options.Analytics.Visitors;

namespace Skybrud.Integrations.Siteimprove.Endpoints.Analytics {
    
    public class SiteimproveAnalyticsVisitorsRawEndpoint {

        #region Properties

        public SiteimproveClient Client { get; private set; }

        public SiteimproveAnalyticsRawEndpoint Analytics { get; private set; }

        #endregion

        #region Constructor

        internal SiteimproveAnalyticsVisitorsRawEndpoint(SiteimproveClient client, SiteimproveAnalyticsRawEndpoint analytics) {
            Client = client;
            Analytics = analytics;
        }

        #endregion

        public IHttpResponse GetDevices(int siteId) {
            return GetDevices(siteId, 0, 0, 0, 0, null);
        }

        public IHttpResponse GetDevices(int siteId, int page, int pageSize, string period) {
            return GetDevices(siteId, page, pageSize, 0, 0, period);
        }

        public IHttpResponse GetDevices(int siteId, int page, int pageSize, int groupId, int filterId, string period) {
            return GetDevices(new SiteimproveGetDevicesOptions {
                SiteId = siteId,
                Page = page,
                PageSize = pageSize,
                GroupId = groupId,
                FilterId = filterId,
                Period = period
            });
        }

        public IHttpResponse GetDevices(SiteimproveGetDevicesOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

    }

}