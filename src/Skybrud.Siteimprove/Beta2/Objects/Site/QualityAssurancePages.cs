using Newtonsoft.Json;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta2.Objects.Site {

    public class QualityAssurancePages {

        [JsonProperty("pages_url")]
        public string PagesUrl { get; private set; }

        [JsonProperty("pages")]
        public int Pages { get; private set; }

        public static QualityAssurancePages Parse(JsonObject obj) {
            if (obj == null) return null;
            return new QualityAssurancePages {
                PagesUrl = obj.GetString("pages_url"),
                Pages = obj.GetInt("pages")
            };
        }

    }

}