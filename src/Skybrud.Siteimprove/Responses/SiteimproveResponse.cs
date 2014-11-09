using Newtonsoft.Json;
using Skybrud.Social;
using Skybrud.Social.Http;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Responses {

    public class SiteimproveResponse : SocialJsonObject {

        /// <summary>
        /// Gets a reference to the underlying response.
        /// </summary>
        [JsonIgnore]
        public SocialHttpResponse Response { get; private set; }

        protected SiteimproveResponse(SocialHttpResponse response, JsonObject obj) : base(obj) {
            Response = response;
        }
    
    }

}
