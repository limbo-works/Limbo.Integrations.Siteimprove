using System;
using Newtonsoft.Json;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta2.Objects.SiteSummary {


    public class QualityAssurance {

        [JsonProperty("last_crawl_date")]
        public DateTime LastCrawlDate { get; private set; }

        [JsonProperty("pages")]
        public int Pages { get; private set; }

        [JsonProperty("broken_links")]
        public int BrokenLinks { get; private set; }

        [JsonProperty("misspellings")]
        public int Misspellings { get; private set; }

        public static QualityAssurance Parse(JsonObject obj) {

            // Check if NULL
            if (obj == null) return null;

            return new QualityAssurance {
                LastCrawlDate = obj.GetDateTime("last_crawl_date"),
                Pages = obj.GetInt("pages"),
                BrokenLinks = obj.GetInt("broken_links"),
                Misspellings = obj.GetInt("misspellings")
            };

        }

    }

}
