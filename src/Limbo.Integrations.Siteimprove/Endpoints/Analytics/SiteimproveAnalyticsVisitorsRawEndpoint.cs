using System;
using Limbo.Integrations.Siteimprove.Http;
using Limbo.Integrations.Siteimprove.Options.Analytics.Visitors;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Endpoints.Analytics;

public class SiteimproveAnalyticsVisitorsRawEndpoint {

    #region Properties

    public SiteimproveHttpClient Client { get; }

    public SiteimproveAnalyticsRawEndpoint Analytics { get; }

    #endregion

    #region Constructor

    internal SiteimproveAnalyticsVisitorsRawEndpoint(SiteimproveHttpClient client, SiteimproveAnalyticsRawEndpoint analytics) {
        Client = client;
        Analytics = analytics;
    }

    #endregion

    public IHttpResponse GetDevices(long siteId) {
        return GetDevices(siteId, null, null, null, null, null);
    }

    public IHttpResponse GetDevices(long siteId, int? page, int? pageSize, string? period) {
        return GetDevices(siteId, page, pageSize, null, null, period);
    }

    public IHttpResponse GetDevices(long siteId, int? page, int? pageSize, int? groupId, int? filterId, string? period) {
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