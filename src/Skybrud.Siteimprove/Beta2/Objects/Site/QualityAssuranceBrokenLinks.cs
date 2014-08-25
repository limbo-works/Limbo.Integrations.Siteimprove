using Newtonsoft.Json;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta2.Objects.Site {

    public class QualityAssuranceBrokenLinks {

        [JsonProperty("broken_links_url")]
        public string BrokenLinksUrl { get; private set; }

        [JsonProperty("broken_links")]
        public int BrokenLinks { get; private set; }

        [JsonProperty("clicks_on_broken_links")]
        public int ClicksOnBrokenLinks { get; private set; }

        [JsonProperty("pages_with_broken_links")]
        public int PagesWithBrokenLinks { get; private set; }

        [JsonProperty("pages_with_broken_links_urls")]
        public string PagesWithBrokenLinksUrls { get; private set; }

        public static QualityAssuranceBrokenLinks Parse(JsonObject obj) {
            if (obj == null) return null;
            return new QualityAssuranceBrokenLinks {
                BrokenLinksUrl = obj.GetString("broken_links_url"),
                BrokenLinks = obj.GetInt("broken_links"),
                ClicksOnBrokenLinks = obj.GetInt("clicks_on_broken_links"),
                PagesWithBrokenLinks = obj.GetInt("pages_with_broken_links"),
                PagesWithBrokenLinksUrls = obj.GetString("pages_with_broken_links_urls")
            };
        }

    }

}