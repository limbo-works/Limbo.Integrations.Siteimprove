using System;
using Newtonsoft.Json;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta2.Objects.SiteSummary {

    public class Accessibility {

        [JsonProperty("last_crawl_date")]
        public DateTime LastCrawlDate { get; private set; }

        [JsonProperty("a_errors")]
        public int AErrors { get; private set; }

        [JsonProperty("aa_errors")]
        public int AAErrors { get; private set; }

        [JsonProperty("aaa_errors")]
        public int AAAErrors { get; private set; }

        [JsonProperty("section508_errors")]
        public int Section508Errors { get; private set; }

        public static Accessibility Parse(JsonObject obj) {

            // Check if NULL
            if (obj == null) return null;

            return new Accessibility {
                LastCrawlDate = obj.GetDateTime("last_crawl_date"),
                AErrors = obj.GetInt("a_errors"),
                AAErrors = obj.GetInt("aa_errors"),
                AAAErrors = obj.GetInt("aaa_errors"),
                Section508Errors = obj.GetInt("section508_errors")
            };

        }

    }

}