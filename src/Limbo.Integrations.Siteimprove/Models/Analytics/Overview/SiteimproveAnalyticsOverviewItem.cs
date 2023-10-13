using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.Analytics.Overview {

    public class SiteimproveAnalyticsOverviewItem : SiteimproveObject {

        #region Properties
        
        /// <summary>
        /// Gets the bounce rate is an indication of how many visitors only perform a single page view.
        /// </summary>
        public float BounceRate { get; }

        public DateTime Timestamp { get; }

        /// <summary>
        /// Gets the number of visits registered.
        /// </summary>
        public int Visits { get; }

        /// <summary>
        /// Gets the number of page views registered.
        /// </summary>
        public int PageViews { get; }

        /// <summary>
        /// Gets the number of returning visitors registered.
        /// </summary>
        public int ReturningVisitors { get; }

        /// <summary>
        /// Gets the number of unique vistors registered.
        /// </summary>
        public int UniqueVisitors { get; }

        /// <summary>
        /// Gets the number of new visitors registered. This property isn't returned by the Siteimprove API, but
        /// calculated from <see cref="UniqueVisitors"/> minus <see cref="ReturningVisitors"/>.
        /// </summary>
        public int NewVisitors => UniqueVisitors - ReturningVisitors;

        #endregion

        #region Constructors

        private SiteimproveAnalyticsOverviewItem(JObject obj) : base(obj) {
            BounceRate = obj.GetFloat("bounce_rate");
            Timestamp = obj.GetString("timestamp", DateTime.Parse);
            Visits = obj.GetInt32("visits");
            PageViews = obj.GetInt32("page_views");
            ReturningVisitors = obj.GetInt32("returning_visitors");
            UniqueVisitors = obj.GetInt32("unique_visitors");
        }

        #endregion

        #region Static methods

        public static SiteimproveAnalyticsOverviewItem Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsOverviewItem(obj);
        }

        #endregion

    }

}