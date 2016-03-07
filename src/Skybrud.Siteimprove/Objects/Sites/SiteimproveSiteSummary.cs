using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Sites {
    
    public class SiteimproveSiteSummary : SiteimproveObject {

        #region Properties
        
        [JsonProperty("site_id")]
        public int Id { get; private set; }
        
        [JsonProperty("site_name")]
        public string Name { get; private set; }
        
        [JsonProperty("url")]
        public string Url { get; private set; }
        
        [JsonProperty("page_count")]
        public int PageCount { get; private set; }
        
        [JsonProperty("potential_misspelling_count")]
        public int PotentialMisspellingCount { get; private set; }
        
        [JsonProperty("misspelling_count")]
        public int MisspellingCount { get; private set; }
        
        [JsonProperty("broken_link_count")]
        public int BrokenLinkCount { get; private set; }
        
        [JsonProperty("_links")]
        public LinkCollection Links { get; private set; }

        #endregion

        #region Constructor

        private SiteimproveSiteSummary(JObject obj) : base(obj) {
            Id = obj.GetInt32("site_id");
            Name = obj.GetString("site_name");
            Url = obj.GetString("url");
            PageCount = obj.GetInt32("page_count");
            PotentialMisspellingCount = obj.GetInt32("potential_misspelling_count");
            MisspellingCount = obj.GetInt32("misspelling_count");
            BrokenLinkCount = obj.GetInt32("broken_link_count");
            Links = obj.GetObject("_links", LinkCollection.Parse);
        }

        #endregion

        #region Static methods

        public static SiteimproveSiteSummary Parse(JObject obj) {
            return obj == null ? null : new SiteimproveSiteSummary(obj);
        }

        #endregion

        public class LinkCollection : SiteimproveObject {

            #region Properties

            [JsonProperty("site")]
            public string Site { get; private set; }

            #endregion

            #region Constructor

            private LinkCollection(JObject obj) : base(obj) {
                Site = obj.GetString("site");
            }

            #endregion

            #region Static methods

            public static LinkCollection Parse(JObject obj) {
                return obj == null ? null : new LinkCollection(obj);
            }

            #endregion

        }
    
    }

}
