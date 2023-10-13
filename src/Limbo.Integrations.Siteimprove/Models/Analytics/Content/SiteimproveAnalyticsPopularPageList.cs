using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace Limbo.Integrations.Siteimprove.Models.Analytics.Content {

    public class SiteimproveAnalyticsPopularPageList : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the items (popular pages) on the current page.
        /// </summary>
        public IReadOnlyList<SiteimproveAnalyticsPopularPage> Items { get; }

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

        private SiteimproveAnalyticsPopularPageList(JObject obj) : base(obj) {
            Items = obj.GetArrayItems("items", SiteimproveAnalyticsPopularPage.Parse)!;
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
        }

        #endregion

        #region Static methods

        [return: NotNullIfNotNull("obj")]
        public static SiteimproveAnalyticsPopularPageList? Parse(JObject? obj) {
            return obj == null ? null : new SiteimproveAnalyticsPopularPageList(obj);
        }

        #endregion

    }

}