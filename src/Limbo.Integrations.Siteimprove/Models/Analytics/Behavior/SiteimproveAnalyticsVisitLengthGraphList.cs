using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.Analytics.Behavior {

    public class SiteimproveAnalyticsVisitLengthGraphList : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the items on the current page.
        /// </summary>
        public SiteimproveAnalyticsVisitLengthGraphItem[] Items { get; }

        /// <summary>
        /// Gets the total amount of items matching the options sent to the API.
        /// </summary>
        public int TotalItems { get; }

        /// <summary>
        /// Gets the total amount of pages matching the options sent to the API.
        /// </summary>
        public int TotalPages { get; }

        #endregion

        #region Constructors

        private SiteimproveAnalyticsVisitLengthGraphList(JObject obj) : base(obj) {
            Items = obj.GetArray("items", SiteimproveAnalyticsVisitLengthGraphItem.Parse);
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
        }

        #endregion

        #region Static methods

        public static SiteimproveAnalyticsVisitLengthGraphList Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsVisitLengthGraphList(obj);
        }

        #endregion

    }

}