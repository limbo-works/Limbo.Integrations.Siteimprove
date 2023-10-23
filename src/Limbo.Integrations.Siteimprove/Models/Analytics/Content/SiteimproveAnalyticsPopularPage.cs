using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.Analytics.Content;

public class SiteimproveAnalyticsPopularPage : SiteimproveObject {

    #region Properties

    /// <summary>
    /// Gets the ID of the page.
    /// </summary>
    public int Id { get; }

    /// <summary>
    /// Gets the title of the page.
    /// </summary>
    public string Title { get; }

    /// <summary>
    /// Gets the URL of the page.
    /// </summary>
    public string Url { get; }

    /// <summary>
    /// Gets the bounce rate is an indication of how many visitors only perform a single page view.
    /// </summary>
    public float BounceRate { get; }

    /// <summary>
    /// Gets a timestamp for last time the page was visited.
    /// </summary>
    public DateTime LastVisited { get; }

    /// <summary>
    /// Gets the average amount of page views per visit.
    /// </summary>
    public float AveragePageViewsPerVisit { get; }

    /// <summary>
    /// Gets the number of page views registered for the page.
    /// </summary>
    public int PageViews { get; }

    /// <summary>
    /// Gets the number of visits registered for the page.
    /// </summary>
    public int Visits { get; }

    /// <summary>
    /// Gets whether the page has an integration with Quality Assurance.
    /// </summary>
    public bool HasIntegration { get; }

    /// <summary>
    /// Gets the rank of the page.
    /// </summary>
    public int Rank { get; }

    #endregion

    #region Constructors

    private SiteimproveAnalyticsPopularPage(JObject obj) : base(obj) {
        Id = obj.GetInt32("id");
        Title = obj.GetString("title")!;
        Url = obj.GetString("url")!;
        BounceRate = obj.GetFloat("bounce_rate");
        LastVisited = obj.GetString("last_visited", DateTime.Parse);
        AveragePageViewsPerVisit = obj.GetFloat("average_page_views_per_visit");
        PageViews = obj.GetInt32("page_views");
        Visits = obj.GetInt32("visits");
        HasIntegration = obj.GetBoolean("has_integration");
        Rank = obj.GetInt32("rank");
    }

    #endregion

    #region Static methods

    [return: NotNullIfNotNull("obj")]
    public static SiteimproveAnalyticsPopularPage? Parse(JObject? obj) {
        return obj == null ? null : new SiteimproveAnalyticsPopularPage(obj);
    }

    #endregion

}