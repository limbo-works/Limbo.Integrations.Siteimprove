using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Skybrud.Social;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Objects {
    
    public class SiteimproveSiteSummary : SocialJsonObject {

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
        public Dictionary<string, string> Links { get; private set; }

        #endregion

        #region Constructor

        private SiteimproveSiteSummary(JsonObject obj) : base(obj) { }

        #endregion

        #region Static methods

        public static SiteimproveSiteSummary Parse(JsonObject obj) {
            if (obj == null) return null;
            JsonObject links = obj.GetObject("_links");
            return new SiteimproveSiteSummary(obj) {
                Id = obj.GetInt32("site_id"),
                Name = obj.GetString("site_name"),
                Url = obj.GetString("url"),
                PageCount = obj.GetInt32("page_count"),
                PotentialMisspellingCount = obj.GetInt32("potential_misspelling_count"),
                MisspellingCount = obj.GetInt32("misspelling_count"),
                BrokenLinkCount = obj.GetInt32("broken_link_count"),
                Links = links.Keys.ToDictionary(key => key, links.GetString)
            };
        }

        #endregion
    
    }

}
