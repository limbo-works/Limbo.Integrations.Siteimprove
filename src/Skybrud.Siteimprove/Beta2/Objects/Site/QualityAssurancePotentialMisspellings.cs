using Newtonsoft.Json;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta2.Objects.Site {

    public class QualityAssurancePotentialMisspellings {

        [JsonProperty("potential_misspellings")]
        public int PotentialMisspellings { get; private set; }

        [JsonProperty("potential_misspellings_url")]
        public string PotentialMisspellingsUrl { get; private set; }

        [JsonProperty("pages_with_potential_misspellings")]
        public int PagesWithPotentialMisspellings { get; private set; }

        [JsonProperty("pages_with_potential_misspellings_url")]
        public string PagesWithPotentialMisspellingsUrl { get; private set; }

        public static QualityAssurancePotentialMisspellings Parse(JsonObject obj) {
            if (obj == null) return null;
            return new QualityAssurancePotentialMisspellings {
                PotentialMisspellings = obj.GetInt("potential_misspellings"),
                PotentialMisspellingsUrl = obj.GetString("potential_misspellings_url"),
                PagesWithPotentialMisspellings = obj.GetInt("pages_with_potential_misspellings"),
                PagesWithPotentialMisspellingsUrl = obj.GetString("pages_with_potential_misspellings_url")
            };
        }

    }

}