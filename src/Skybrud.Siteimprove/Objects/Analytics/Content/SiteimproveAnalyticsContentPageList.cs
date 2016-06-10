using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Analytics.Content {
    
    /// <summary>
    /// Class representing a list of <see cref="SiteimproveAnalyticsContentPage"/>.
    /// </summary>
    public class SiteimproveAnalyticsContentPageList : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the items (content pages) on the current page.
        /// </summary>
        public SiteimproveAnalyticsContentPage[] Items { get; private set; }

        /// <summary>
        /// Gets the total amount of items matching the options sent to the API.
        /// </summary>
        public int TotalItems { get; private set; }

        /// <summary>
        /// Gets the total amount of pages matching the options sent to the API.
        /// </summary>
        public int TotalPages { get; private set; }

        /// <summary>
        /// Gets a set of aggregations for en entire result set.
        /// </summary>
        public SiteimproveAnalyticsContentPageListAggregations Aggregations { get; private set; }

        #endregion

        #region Constructors

        private SiteimproveAnalyticsContentPageList(JObject obj) : base(obj) {
            Items = obj.GetArray("items", SiteimproveAnalyticsContentPage.Parse);
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
            Aggregations = obj.GetObject("aggregations", SiteimproveAnalyticsContentPageListAggregations.Parse);
        }

        #endregion

        #region Static methods

        public static SiteimproveAnalyticsContentPageList Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsContentPageList(obj);
        }

        #endregion

    }

}