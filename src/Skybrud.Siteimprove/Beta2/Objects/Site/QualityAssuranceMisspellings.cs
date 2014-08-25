using Newtonsoft.Json;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta2.Objects.Site {

    public class QualityAssuranceMisspellings {

        [JsonProperty("misspellings")]
        public int Misspellings { get; private set; }

        [JsonProperty("misspellings_url")]
        public string MisspellingsUrl { get; private set; }

        [JsonProperty("pages_with_misspellings")]
        public int PagesWithMisspellings { get; private set; }

        [JsonProperty("pages_with_misspellings_url")]
        public string PagesWithMisspellingsUrl { get; private set; }

        public static QualityAssuranceMisspellings Parse(JsonObject obj) {
            if (obj == null) return null;
            return new QualityAssuranceMisspellings {
                Misspellings = obj.GetInt("misspellings"),
                MisspellingsUrl = obj.GetString("misspellings_url"),
                PagesWithMisspellings = obj.GetInt("pages_with_misspellings"),
                PagesWithMisspellingsUrl = obj.GetString("pages_with_misspellings_url")
            };
        }

    }

}