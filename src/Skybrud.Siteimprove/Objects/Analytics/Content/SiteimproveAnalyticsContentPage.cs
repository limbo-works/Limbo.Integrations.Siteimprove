using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Analytics.Content {

    public class SiteimproveAnalyticsContentPage : SiteimproveObject {

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

        #endregion

        #region Constructors

        private SiteimproveAnalyticsContentPage(JObject obj) : base(obj) {
            Id = obj.GetInt32("id");
            Title = obj.GetString("title");
            Url = obj.GetString("url");
            BounceRate = obj.GetFloat("bounce_rate");
            AveragePageViewsPerVisit = obj.GetFloat("average_page_views_per_visit");
            PageViews = obj.GetInt32("page_views");
            Visits = obj.GetInt32("visits");
            HasIntegration = obj.GetBoolean("has_integration");
            // page_level
            // page_score
            // cms_url
            // _siteimprove
        }

        #endregion

        #region Static methods

        public static SiteimproveAnalyticsContentPage Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsContentPage(obj);
        }

        #endregion

    }

}