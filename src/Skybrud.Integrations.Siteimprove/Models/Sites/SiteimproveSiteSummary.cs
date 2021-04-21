using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Integrations.Siteimprove.Models.Sites {
    
    public class SiteimproveSiteSummary : SiteimproveObject {

        #region Properties
        
        [JsonProperty("id")]
        public long Id { get; private set; }
        
        [JsonProperty("site_name")]
        public string Name { get; private set; }
        
        [JsonProperty("url")]
        public string Url { get; private set; }
        
        [JsonProperty("pages")]
        public int Pages { get; private set; }
        
        [JsonProperty("policies")]
        public int Policies { get; private set; }

        [JsonProperty("product")]
        public string[] Product { get; private set; }

        [JsonProperty("visits")]
        public int Visits { get; private set; }

        #endregion

        #region Constructor

        protected SiteimproveSiteSummary(JObject obj) : base(obj) {
            Id = obj.GetInt64("id");
            Name = obj.GetString("site_name");
            Url = obj.GetString("url");
            Pages = obj.GetInt32("pages");
            Policies = obj.GetInt32("policies");
            Product = obj.GetStringArray("product");
            Visits = obj.GetInt32("visits");
        }

        #endregion

        #region Static methods

        public static SiteimproveSiteSummary Parse(JObject obj) {
            return obj == null ? null : new SiteimproveSiteSummary(obj);
        }

        #endregion

    }

}