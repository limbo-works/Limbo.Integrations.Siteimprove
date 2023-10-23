using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;

namespace Limbo.Integrations.Siteimprove.Options.Analytics;

public abstract class SiteimproveAnalyticsOptionsBase : IHttpRequestOptions {

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
    /// <remarks>
    /// Siteimprove's documentation specifies that the type of the <c>page_id</c> parameter is <see cref="long"/>, but
    /// also that the <c>id</c> property of the returned page items is <see cref="ulong"/>.
    /// </remarks>
    public ulong? PageId { get; set; }

    /// <summary>
    /// Gets or sets the period for which to retrieve data.
    /// </summary>
    public SiteimprovePeriod? Period { get; set; }

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
    protected SiteimproveAnalyticsOptionsBase() { }

    /// <summary>
    /// Initializes a new instance with the specified <paramref name="siteId"/>.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
#if NET7_0_OR_GREATER
    [System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
    protected SiteimproveAnalyticsOptionsBase(long siteId) {
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
    protected SiteimproveAnalyticsOptionsBase(long siteId, int? page, int? pageSize) {
        SiteId = siteId;
        Page = page;
        PageSize = pageSize;
    }

    #endregion

    #region Member methods

    protected virtual IHttpQueryString GetQueryString() {

        IHttpQueryString query = new HttpQueryString();
        if (Page > 0) query.Add("page", Page);
        if (PageSize > 0) query.Add("page_size", PageSize);
        if (GroupId > 0) query.Add("group_id", GroupId);
        if (FilterId > 0) query.Add("filter_id", FilterId);
        if (PageId > 0) query.Add("page_id", PageId);
        if (Period is not null) query.Add("period", Period!);

        return query;

    }

    public abstract IHttpRequest GetRequest();

    #endregion

}