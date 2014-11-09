using Newtonsoft.Json;
using Skybrud.Siteimprove.Objects;
using Skybrud.Social.Http;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Responses {

    public class SiteimproveSitesResponse : SiteimproveResponse {

        #region Properties

        [JsonProperty("items")]
        public SiteimproveSiteSummary[] Items { get; private set; }
        
        [JsonProperty("total_items")]
        public int TotalItems { get; private set; }
        
        [JsonProperty("total_pages")]
        public int TotalPages { get; private set; }

        #endregion

        #region Constructor

        private SiteimproveSitesResponse(SocialHttpResponse response, JsonObject obj) : base(response, obj) { }

        #endregion

        #region Static methods

        public static SiteimproveSitesResponse ParseResponse(SocialHttpResponse response) {

            if (response == null) return null;

            // Parse the raw JSON response
            JsonObject obj = response.GetBodyAsJsonObject();

            return new SiteimproveSitesResponse(response, obj) {
                Items = obj.GetArray("items", SiteimproveSiteSummary.Parse),
                TotalItems = obj.GetInt32("total_items"),
                TotalPages = obj.GetInt32("total_pages")
            };

        }

        #endregion

    }

}
