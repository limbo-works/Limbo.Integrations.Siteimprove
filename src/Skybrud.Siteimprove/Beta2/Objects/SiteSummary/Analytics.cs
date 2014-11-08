using System;
using Newtonsoft.Json;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta2.Objects.SiteSummary {

    public class Analytics {

        [JsonProperty("start")]
        public DateTime Start { get; private set; }

        [JsonProperty("end")]
        public DateTime End { get; private set; }

        [JsonProperty("pageviews")]
        public int Pageviews { get; private set; }

        [JsonProperty("visits")]
        public int Visits { get; private set; }

        [JsonProperty("bounce_rate")]
        public float BounceRate { get; private set; }

        public static Analytics Parse(JsonObject obj) {

            // Check if NULL
            if (obj == null) return null;

            return new Analytics {
                Start = obj.GetDateTime("start"),
                End = obj.GetDateTime("end"),
                Pageviews = obj.GetInt("pageviews"),
                Visits = obj.GetInt("visits"),
                BounceRate = obj.GetFloat("bounce_rate")
            };

        }

    }

}