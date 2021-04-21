using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Integrations.Siteimprove.Models.Analytics.Content {

    public class SiteimproveAnalyticsPopularPage : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the page.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Gets the title of the page.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Gets the URL of the page.
        /// </summary>
        public string Url { get; private set; }

        /// <summary>
        /// Gets the bounce rate is an indication of how many visitors only perform a single page view.
        /// </summary>
        public float BounceRate { get; private set; }

        /// <summary>
        /// Gets a timestamp for last time the page was visited.
        /// </summary>
        public DateTime LastVisited { get; private set; }

        /// <summary>
        /// Gets the average amount of page views per visit.
        /// </summary>
        public float AveragePageViewsPerVisit { get; private set; }

        /// <summary>
        /// Gets the number of page views registered for the page.
        /// </summary>
        public int PageViews { get; private set; }

        /// <summary>
        /// Gets the number of visits registered for the page.
        /// </summary>
        public int Visits { get; private set; }

        /// <summary>
        /// Gets whether the page has an integration with Quality Assurance.
        /// </summary>
        public bool HasIntegration { get; private set; }

        /// <summary>
        /// Gets the rank of the page.
        /// </summary>
        public int Rank { get; private set; }

        #endregion

        #region Constructors

        private SiteimproveAnalyticsPopularPage(JObject obj) : base(obj) {
            Id = obj.GetInt32("id");
            Title = obj.GetString("title");
            Url = obj.GetString("url");
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

        public static SiteimproveAnalyticsPopularPage Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsPopularPage(obj);
        }

        #endregion

    }

}