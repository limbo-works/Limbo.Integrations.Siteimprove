﻿using System;
using System.Diagnostics.CodeAnalysis;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;

namespace Limbo.Integrations.Siteimprove.Options.Analytics;

public abstract class SiteimproveAnalyticsGetPeriodOptionsNope : IHttpRequestOptions {

    #region Properties

    /// <summary>
    /// Gets or sets the ID of the site.
    /// </summary>
#if NET7_0_OR_GREATER
    public required long SiteId { get; set; }
#else
    public long SiteId { get; set; }
#endif

    /// <summary>
    /// Gets the sets the ID for specific group.
    /// </summary>
    public long? GroupId { get; set; }

    /// <summary>
    /// Gets the sets the ID for specific filter.
    /// </summary>
    public long? FilterId { get; set; }

    /// <summary>
    /// Gets or sets the ID of the page that should be returned. Not all endpoints support this property.
    /// </summary>
    public long? PageId { get; set; }

    /// <summary>
    /// Gets or sets the period for which to retrieve data.
    /// </summary>
    public string? Period { get; set; }

    /// <summary>
    /// Gets or sets the page number to show when more than one page in paged output.
    /// </summary>
    public int? Page { get; set; }

    /// <summary>
    /// Gets or sets the number of items/records per page in paged output.
    /// </summary>
    public int? PageSize { get; set; }

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance with default options.
    /// </summary>
    protected SiteimproveAnalyticsGetPeriodOptionsNope() { }

    /// <summary>
    /// Initializes a new instance with the specified <paramref name="siteId"/>.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
#if NET7_0_OR_GREATER
    [SetsRequiredMembers]
#endif
    protected SiteimproveAnalyticsGetPeriodOptionsNope(long siteId) {
        SiteId = siteId;
    }

    /// <summary>
    /// Initializes a new instance with the specified <paramref name="siteId"/>, <paramref name="page"/> and <paramref name="pageSize"/>.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
    /// <param name="page">The page that should be returned.</param>
    /// <param name="pageSize">The maximum amount of items per page.</param>
#if NET7_0_OR_GREATER
    [SetsRequiredMembers]
#endif
    protected SiteimproveAnalyticsGetPeriodOptionsNope(long siteId, int? page, int? pageSize) {
        SiteId = siteId;
        Page = page;
        PageSize = pageSize;
    }

    #endregion

    #region Member methods

    /// <summary>
    /// Sets the <see cref="Period"/> property based on the specified <paramref name="day"/>.
    /// </summary>
    /// <param name="day">The day.</param>
    /// <returns>Returns the options instance for method chaining.</returns>
    public SiteimproveAnalyticsGetPeriodOptionsNope SetPeriod(DateTime day) {
        Period = day.ToString("yyyyMMdd");
        return this;
    }

    /// <summary>
    /// Sets the <see cref="Period"/> property based on the specified <paramref name="from"/> and <paramref name="to"/>.
    /// </summary>
    /// <param name="from">The start date of the period.</param>
    /// <param name="to">The end date of the period.</param>
    /// <returns>Returns the options instance for method chaining.</returns>
    public SiteimproveAnalyticsGetPeriodOptionsNope SetPeriod(DateTime from, DateTime to) {
        Period = $"{from:yyyyMMdd}_{to:yyyyMMdd}";
        return this;
    }

    protected virtual IHttpQueryString GetQueryString() {

        IHttpQueryString query = new HttpQueryString();
        if (Page > 0) query.Add("page", Page);
        if (PageSize > 0) query.Add("page_size", PageSize);
        if (GroupId > 0) query.Add("group_id", GroupId);
        if (FilterId > 0) query.Add("filter_id", FilterId);
        if (PageId > 0) query.Add("page_id", PageId);
        if (!string.IsNullOrWhiteSpace(Period)) query.Add("period", Period!);

        return query;

    }

    public abstract IHttpRequest GetRequest();

    #endregion

}