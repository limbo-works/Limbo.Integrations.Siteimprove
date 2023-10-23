using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Options.Analytics.Visitors;

public class SiteimproveGetDevicesOptions : SiteimproveAnalyticsOptionsBase {

    #region Constructors

    /// <summary>
    /// Initializes a new instance with default options.
    /// </summary>
    public SiteimproveGetDevicesOptions() { }

    /// <summary>
    /// Initializes a new instance with the specified <paramref name="siteId"/>.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
    public SiteimproveGetDevicesOptions(long siteId) {
        SiteId = siteId;
    }

    /// <summary>
    /// Initializes a new instance with the specified <paramref name="siteId"/>, <paramref name="page"/> and <paramref name="pageSize"/>.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
    /// <param name="page">The page that should be returned.</param>
    /// <param name="pageSize">The maximum amount of items per page.</param>
    public SiteimproveGetDevicesOptions(long siteId, int page, int pageSize) {
        SiteId = siteId;
        Page = page;
        PageSize = pageSize;
    }

    #endregion

    #region Member methods

    public override IHttpRequest GetRequest() {

        if (SiteId == 0) throw new PropertyNotSetException(nameof(SiteId));

        // Initialize a new request
        return HttpRequest.Get($"/v2/sites/{SiteId}/analytics/visitors/devices", GetQueryString());

    }

    #endregion

}