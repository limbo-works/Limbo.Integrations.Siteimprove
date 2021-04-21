using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Integrations.Siteimprove.Models.Analytics.Content {
    
    public class SiteimproveAnalyticsPopularPagesList : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the items (popular pages) on the current page.
        /// </summary>
        public SiteimproveAnalyticsPopularPage[] Items { get; private set; }

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

        private SiteimproveAnalyticsPopularPagesList(JObject obj) : base(obj) {
            Items = obj.GetArray("items", SiteimproveAnalyticsPopularPage.Parse);
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
        }

        #endregion

        #region Static methods

        public static SiteimproveAnalyticsPopularPagesList Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsPopularPagesList(obj);
        }

        #endregion

    }

}