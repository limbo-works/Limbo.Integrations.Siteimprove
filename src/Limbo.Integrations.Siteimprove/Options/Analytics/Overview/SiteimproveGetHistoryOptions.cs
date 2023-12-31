﻿using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Options.Analytics.Overview;

public class SiteimproveGetHistoryOptions : SiteimproveAnalyticsOptionsBase {

    #region Constructors

    /// <summary>
    /// Initializes a new instance with default options.
    /// </summary>
    public SiteimproveGetHistoryOptions() { }

    /// <summary>
    /// Initializes a new instance with the specified <paramref name="siteId"/>.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
#if NET7_0_OR_GREATER
    [System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
    public SiteimproveGetHistoryOptions(long siteId) {
        SiteId = siteId;
    }

    /// <summary>
    /// Initializes a new instance with the specified <paramref name="siteId"/>, <paramref name="page"/> and <paramref name="pageSize"/>.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
    /// <param name="page">The page that should be returned.</param>
    /// <param name="pageSize">The maximum amount of items per page.</param>
#if NET7_0_OR_GREATER
    [System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
    public SiteimproveGetHistoryOptions(long siteId, int page, int pageSize) {
        SiteId = siteId;
        Page = page;
        PageSize = pageSize;
    }

    #endregion

    #region Member methods

    public override IHttpRequest GetRequest() {

        if (SiteId == 0) throw new PropertyNotSetException(nameof(SiteId));

        // Initialize a new request
        return HttpRequest.Get($"/v2/sites/{SiteId}/analytics/overview/history", GetQueryString());

    }

    #endregion

}