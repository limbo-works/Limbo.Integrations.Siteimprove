using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace Limbo.Integrations.Siteimprove.Models.Analytics.Content;

/// <summary>
/// Class representing a list of <see cref="SiteimproveAnalyticsContentPage"/>.
/// </summary>
public class SiteimproveAnalyticsPageList : SiteimproveObject {

    #region Properties

    /// <summary>
    /// Gets the items (content pages) on the current page.
    /// </summary>
    public IReadOnlyList<SiteimproveAnalyticsContentPage> Items { get; }

    /// <summary>
    /// Gets the total amount of items matching the options sent to the API.
    /// </summary>
    public int TotalItems { get; }

    /// <summary>
    /// Gets the total amount of pages matching the options sent to the API.
    /// </summary>
    public int TotalPages { get; }

    /// <summary>
    /// Gets a set of aggregations for en entire result set.
    /// </summary>
    public SiteimproveAnalyticsContentPageListAggregations Aggregations { get; }

    #endregion

    #region Constructors

    private SiteimproveAnalyticsPageList(JObject obj) : base(obj) {
        Items = obj.GetArray("items", SiteimproveAnalyticsContentPage.Parse)!;
        TotalItems = obj.GetInt32("total_items");
        TotalPages = obj.GetInt32("total_pages");
        Aggregations = obj.GetObject("aggregations", SiteimproveAnalyticsContentPageListAggregations.Parse)!;
    }

    #endregion

    #region Static methods

    [return: NotNullIfNotNull("obj")]
    public static SiteimproveAnalyticsPageList? Parse(JObject? obj) {
        return obj == null ? null : new SiteimproveAnalyticsPageList(obj);
    }

    #endregion

}