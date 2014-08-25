using Newtonsoft.Json;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta2.Objects.Site {

    public class QualityAssuranceLinks {

        [JsonProperty("links_url")]
        public string LinksUrl { get; private set; }

        [JsonProperty("links")]
        public int Links { get; private set; }

        public static QualityAssuranceLinks Parse(JsonObject obj) {
            if (obj == null) return null;
            return new QualityAssuranceLinks {
                LinksUrl = obj.GetString("links_url"),
                Links = obj.GetInt("links")
            };
        }

    }

}