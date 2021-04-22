using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Integrations.Siteimprove.Models.Analytics.Visitors {
   
    public class SiteimproveAnalyticsDeviceList : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the items (devices) on the current page.
        /// </summary>
        public SiteimproveAnalyticsDevice[] Items { get; }

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
            Items = obj.GetArray("items", SiteimproveAnalyticsDevice.Parse);
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
            Aggregations = obj.GetObject("aggregations", SiteimproveAnalyticsDeviceListAggregations.Parse);
        }

        #endregion

        #region Static methods

        public static SiteimproveAnalyticsDeviceList Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsDeviceList(obj);
        }

        #endregion

    }

}