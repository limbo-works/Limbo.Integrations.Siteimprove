using Limbo.Integrations.Siteimprove.Options.Analytics.Visitors;
using Limbo.Integrations.Siteimprove.Responses.Analytics.Visitors;

namespace Limbo.Integrations.Siteimprove.Endpoints.Analytics;

public class SiteimproveAnalyticsVisitorsEndpoint {

    #region Properties

    /// <summary>
    /// A reference to the Siteimprove service.
    /// </summary>
    public SiteimproveHttpService Service { get; }

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

    internal SiteimproveAnalyticsVisitorsEndpoint(SiteimproveHttpService service, SiteimproveAnalyticsEndpoint analytics) {
        Service = service;
        Analytics = analytics;
    }

    #endregion

    #region Member methods

    public SiteimproveAnalyticsDeviceListResponse GetDevices(long siteId) {
        return new SiteimproveAnalyticsDeviceListResponse(Raw.GetDevices(siteId));
    }

    public SiteimproveAnalyticsDeviceListResponse GetDevices(long siteId, int page, int pageSize, string period) {
        return new SiteimproveAnalyticsDeviceListResponse(Raw.GetDevices(siteId, page, pageSize, period));
    }

    public SiteimproveAnalyticsDeviceListResponse GetDevices(long siteId, int page, int pageSize, int groupId, int filterId, string period) {
        return new SiteimproveAnalyticsDeviceListResponse(Raw.GetDevices(siteId, page, pageSize, groupId, filterId, period));
    }

    public SiteimproveAnalyticsDeviceListResponse GetDevices(SiteimproveGetDevicesOptions options) {
        return new SiteimproveAnalyticsDeviceListResponse(Raw.GetDevices(options));
    }

    #endregion

}