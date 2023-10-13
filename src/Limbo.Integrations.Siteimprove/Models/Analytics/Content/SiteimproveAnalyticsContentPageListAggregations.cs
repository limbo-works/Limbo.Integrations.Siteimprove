using Limbo.Integrations.Siteimprove.Models.Common.Aggregations;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.Analytics.Content {
    
    public class SiteimproveAnalyticsContentPageListAggregations : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the total amount of page views across the entire result set.
        /// </summary>
        public SiteimproveAnalyticsSumAggregation PageViews { get; }

        /// <summary>
        /// Gets the total amount of visits across the entire result set.
        /// </summary>
        public SiteimproveAnalyticsSumAggregation Visits { get; }

        #endregion

        #region Constructors

        private SiteimproveAnalyticsContentPageListAggregations(JObject obj) : base(obj) {
            PageViews = obj.GetObject("page_views", SiteimproveAnalyticsSumAggregation.Parse);
            Visits = obj.GetObject("visits", SiteimproveAnalyticsSumAggregation.Parse);
        }

        #endregion

        #region Static methods

        public static SiteimproveAnalyticsContentPageListAggregations Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsContentPageListAggregations(obj);
        }

        #endregion

    }

}