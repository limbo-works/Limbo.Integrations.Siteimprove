using System;
using Newtonsoft.Json;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta2.Objects.Site {

    public class QualityAssurance {

        [JsonProperty("last_crawl_date")]
        public DateTime LastCrawlDate { get; private set; }

        [JsonProperty("crawl_rate")]
        public int CrawlRate { get; private set; }

        [JsonProperty("pages")]
        public QualityAssurancePages Pages { get; private set; }

        [JsonProperty("links")]
        public QualityAssuranceLinks Links { get; private set; }

        [JsonProperty("broken_links")]
        public QualityAssuranceBrokenLinks BrokenLinks { get; private set; }

        [JsonProperty("misspellings")]
        public QualityAssuranceMisspellings Misspellings { get; private set; }

        [JsonProperty("potential_misspellings")]
        public QualityAssurancePotentialMisspellings PotentialMisspellings { get; private set; }

        [JsonProperty("priority_pages")]
        public QualityAssurancePriorityPage[] PriorityPages { get; private set; }

        [JsonProperty("personal_id_numbers")]
        public int PersonalIdNumbers { get; private set; }

        public static QualityAssurance Parse(JsonObject obj) {

            // Check if NULL
            if (obj == null) return null;

            return new QualityAssurance {
                LastCrawlDate = obj.GetDateTime("last_crawl_date"),
                CrawlRate = obj.GetInt("crawl_rate"),
                Pages = obj.GetObject("pages", QualityAssurancePages.Parse),
                Links = obj.GetObject("links", QualityAssuranceLinks.Parse),
                BrokenLinks = obj.GetObject("broken_links", QualityAssuranceBrokenLinks.Parse),
                Misspellings = obj.GetObject("misspellings", QualityAssuranceMisspellings.Parse),
                PotentialMisspellings = obj.GetObject("potential_misspellings", QualityAssurancePotentialMisspellings.Parse),
                PriorityPages = obj.GetArray("priority_pages", QualityAssurancePriorityPage.Parse),
                PersonalIdNumbers = obj.GetInt("personal_id_numbers")
            };

        }

    }

}