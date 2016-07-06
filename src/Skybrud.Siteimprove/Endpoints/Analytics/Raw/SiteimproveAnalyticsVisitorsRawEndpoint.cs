using System;
using Skybrud.Siteimprove.Exceptions;
using Skybrud.Siteimprove.Options.Analytics;
using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Endpoints.Analytics.Raw {
    
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

        public SocialHttpResponse GetDevices(int siteId) {
            return GetDevices(siteId, 0, 0, 0, 0, null);
        }

        public SocialHttpResponse GetDevices(int siteId, int page, int pageSize, string period) {
            return GetDevices(siteId, 0, 0, 0, 0, null);
        }

        public SocialHttpResponse GetDevices(int siteId, int page, int pageSize, int groupId, int filterId, string period) {
            return GetDevices(new SiteimproveAnalyticsGetPeriodOptions {
                SiteId = siteId,
                Page = page,
                PageSize = pageSize,
                GroupId = groupId,
                FilterId = filterId,
                Period = period
            });
        }

        public SocialHttpResponse GetDevices(SiteimproveAnalyticsGetPeriodOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            if (options.SiteId == 0) throw new PropertyNotSetException("options.SiteId");
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrlV2 + "sites/" + options.SiteId + "/analytics/visitors/devices", options);
        }

    }

}