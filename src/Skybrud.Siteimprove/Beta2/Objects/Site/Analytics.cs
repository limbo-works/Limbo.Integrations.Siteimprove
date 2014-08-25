using System;
using Newtonsoft.Json;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta2.Objects.Site {

    public class Analytics {

        [JsonProperty("start")]
        public DateTime Start { get; private set; }

        [JsonProperty("end")]
        public DateTime End { get; private set; }

        [JsonProperty("pageviews")]
        public int Pageviews { get; private set; }

        [JsonProperty("sessions")]
        public int Sessions { get; private set; }

        [JsonProperty("unique_sessions")]
        public int UniqueSessions { get; private set; }

        [JsonProperty("most_popular_pages")]
        public AnalyticsPopularPage[] MostPopularPages { get; private set; }

        public static Analytics Parse(JsonObject obj) {

            // Check if NULL
            if (obj == null) return null;

            return new Analytics {
                Start = obj.GetDateTime("start"),
                End = obj.GetDateTime("end"),
                Pageviews = obj.GetInt("pageviews"),
                Sessions = obj.GetInt("sessions"),
                UniqueSessions = obj.GetInt("unique_sessions"),
                MostPopularPages = obj.GetArray("most_popular_pages", AnalyticsPopularPage.Parse)
            };

        }

    }

}