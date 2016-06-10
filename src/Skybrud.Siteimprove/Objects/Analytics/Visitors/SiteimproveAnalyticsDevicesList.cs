using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Analytics.Visitors {
   
    public class SiteimproveAnalyticsDevicesList : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the items (devices) on the current page.
        /// </summary>
        public SiteimproveAnalyticsDevice[] Items { get; private set; }

        /// <summary>
        /// Gets the total amount of items matching the options sent to the API.
        /// </summary>
        public int TotalItems { get; private set; }

        /// <summary>
        /// Gets the total amount of pages matching the options sent to the API.
        /// </summary>
        public int TotalPages { get; private set; }
        
        public SiteimproveAnalyticsDevicesListAggregations Aggregations { get; private set; }

        #endregion

        #region Constructors

        private SiteimproveAnalyticsDevicesList(JObject obj) : base(obj) {
            Items = obj.GetArray("items", SiteimproveAnalyticsDevice.Parse);
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
            Aggregations = obj.GetObject("aggregations", SiteimproveAnalyticsDevicesListAggregations.Parse);
        }

        #endregion

        #region Static methods

        public static SiteimproveAnalyticsDevicesList Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsDevicesList(obj);
        }

        #endregion

    }

}