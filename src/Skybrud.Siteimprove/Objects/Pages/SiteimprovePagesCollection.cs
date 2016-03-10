using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Pages {
    
    public class SiteimprovePagesCollection : SiteimproveObject {

        #region Properties

        [JsonProperty("items")]
        public SiteimprovePageSummary[] Items { get; private set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; private set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; private set; }

        [JsonProperty("_links")]
        public SiteimprovePagesLinksCollection Links { get; private set; }
        
        #endregion

        #region Constructors

        private SiteimprovePagesCollection(JObject obj) : base(obj) {
            Items = obj.GetArray("items", SiteimprovePageSummary.Parse);
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
            Links = obj.GetObject("_links", SiteimprovePagesLinksCollection.Parse);
        }

        #endregion

        #region Static methods

        public static SiteimprovePagesCollection Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePagesCollection(obj);
        }

        #endregion

    }
}