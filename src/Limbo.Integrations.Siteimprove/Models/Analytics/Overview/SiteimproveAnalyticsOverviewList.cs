using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace Limbo.Integrations.Siteimprove.Models.Analytics.Overview;

public class SiteimproveAnalyticsOverviewList : SiteimproveObject {

    #region Properties

    /// <summary>
    /// Gets the items on the current page.
    /// </summary>
    public IReadOnlyList<SiteimproveAnalyticsOverviewItem> Items { get; }

    /// <summary>
    /// Gets the total amount of items matching the options sent to the API.
    /// </summary>
    public int TotalItems { get; }

    /// <summary>
    /// Gets the total amount of pages matching the options sent to the API.
    /// </summary>
    public int TotalPages { get; }

    #endregion

    #region Constructors

    private SiteimproveAnalyticsOverviewList(JObject obj) : base(obj) {
        Items = obj.GetArrayItems("items", SiteimproveAnalyticsOverviewItem.Parse)!;
        TotalItems = obj.GetInt32("total_items");
        TotalPages = obj.GetInt32("total_pages");
    }

    #endregion

    #region Static methods

    [return: NotNullIfNotNull("obj")]
    public static SiteimproveAnalyticsOverviewList? Parse(JObject? obj) {
        return obj == null ? null : new SiteimproveAnalyticsOverviewList(obj);
    }

    #endregion

}