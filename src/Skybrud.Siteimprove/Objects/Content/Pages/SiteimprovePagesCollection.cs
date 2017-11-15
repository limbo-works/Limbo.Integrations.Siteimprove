using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Siteimprove.Objects.Content.Pages {
    
    public class SiteimprovePagesCollection : SiteimproveObject {

        #region Properties

        [JsonProperty("items")]
        public SiteimprovePageItem[] Items { get; private set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; private set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; private set; }
        
        #endregion

        #region Constructors

        private SiteimprovePagesCollection(JObject obj) : base(obj) {
            Items = obj.GetArray("items", SiteimprovePageItem.Parse);
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
        }

        #endregion

        #region Static methods

        public static SiteimprovePagesCollection Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePagesCollection(obj);
        }

        #endregion

    }

}