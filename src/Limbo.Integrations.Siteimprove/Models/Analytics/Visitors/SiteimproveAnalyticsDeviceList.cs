using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace Limbo.Integrations.Siteimprove.Models.Analytics.Visitors;

public class SiteimproveAnalyticsDeviceList : SiteimproveObject {

    #region Properties

    /// <summary>
    /// Gets the items (devices) on the current page.
    /// </summary>
    public IReadOnlyList<SiteimproveAnalyticsDevice> Items { get; }

    /// <summary>
    /// Gets the total amount of items matching the options sent to the API.
    /// </summary>
    public int TotalItems { get; }

    /// <summary>
    /// Gets the total amount of pages matching the options sent to the API.
    /// </summary>
    public int TotalPages { get; }

    public SiteimproveAnalyticsDeviceListAggregations Aggregations { get; }

    #endregion

    #region Constructors

    private SiteimproveAnalyticsDeviceList(JObject obj) : base(obj) {
        Items = obj.GetArrayItems("items", SiteimproveAnalyticsDevice.Parse)!;
        TotalItems = obj.GetInt32("total_items");
        TotalPages = obj.GetInt32("total_pages");
        Aggregations = obj.GetObject("aggregations", SiteimproveAnalyticsDeviceListAggregations.Parse)!;
    }

    #endregion

    #region Static methods

    [return: NotNullIfNotNull("obj")]
    public static SiteimproveAnalyticsDeviceList? Parse(JObject? obj) {
        return obj == null ? null : new SiteimproveAnalyticsDeviceList(obj);
    }

    #endregion

}