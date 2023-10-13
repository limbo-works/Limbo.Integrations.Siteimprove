using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace Limbo.Integrations.Siteimprove.Models.Content.Pages {

    public class SiteimprovePagesCollection : SiteimproveObject {

        #region Properties

        [JsonProperty("items")]
        public IReadOnlyList<SiteimprovePageItem> Items { get; }

        [JsonProperty("total_items")]
        public int TotalItems { get; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; }

        #endregion

        #region Constructors

        private SiteimprovePagesCollection(JObject obj) : base(obj) {
            Items = obj.GetArrayItems("items", SiteimprovePageItem.Parse)!;
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
        }

        #endregion

        #region Static methods

        [return: NotNullIfNotNull("obj")]
        public static SiteimprovePagesCollection? Parse(JObject? obj) {
            return obj == null ? null : new SiteimprovePagesCollection(obj);
        }

        #endregion

    }

}