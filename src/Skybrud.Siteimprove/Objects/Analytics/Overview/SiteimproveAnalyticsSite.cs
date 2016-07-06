using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Analytics.Overview {
    
    public class SiteimproveAnalyticsSite : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the bounce rate registered for the site.
        /// </summary>
        public float BounceRate { get; private set; }

        /// <summary>
        /// Gets the amount of new visitors registered for the site.
        /// </summary>
        public int NewVisitors { get; private set; }

        /// <summary>
        /// Gets the number of page views registered for the site.
        /// </summary>
        public int PageViews { get; private set; }

        /// <summary>
        /// Gets the amount of returning registered for the site.
        /// </summary>
        public int ReturningVisitors { get; private set; }

        /// <summary>
        /// Gets the number of visits registered for the site.
        /// </summary>
        public int Visits { get; private set; }

        /// <summary>
        /// Gets the number of visits registered for the site.
        /// </summary>
        public int UniqueVisitors { get; private set; }

        #endregion

        #region Constructors

        private SiteimproveAnalyticsSite(JObject obj) : base(obj) {
            BounceRate = obj.GetFloat("bounce_rate");
            NewVisitors = obj.GetInt32("new_visitors");
            PageViews = obj.GetInt32("page_views");
            ReturningVisitors = obj.GetInt32("returning_visitors");
            Visits = obj.GetInt32("visits");
            UniqueVisitors = obj.GetInt32("unique_visitors");
        }

        #endregion

        #region Static methods

        public static SiteimproveAnalyticsSite Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsSite(obj);
        }

        #endregion

    }

}