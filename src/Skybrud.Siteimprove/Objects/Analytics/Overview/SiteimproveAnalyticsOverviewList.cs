using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Analytics.Overview {

    public class SiteimproveAnalyticsOverviewList : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the items on the current page.
        /// </summary>
        public SiteimproveAnalyticsOverviewItem[] Items { get; private set; }

        /// <summary>
        /// Gets the total amount of items matching the options sent to the API.
        /// </summary>
        public int TotalItems { get; private set; }

        /// <summary>
        /// Gets the total amount of pages matching the options sent to the API.
        /// </summary>
        public int TotalPages { get; private set; }

        #endregion

        #region Constructors

        private SiteimproveAnalyticsOverviewList(JObject obj) : base(obj) {
            Items = obj.GetArray("items", SiteimproveAnalyticsOverviewItem.Parse);
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
        }

        #endregion

        #region Static methods

        public static SiteimproveAnalyticsOverviewList Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsOverviewList(obj);
        }

        #endregion

    }

}