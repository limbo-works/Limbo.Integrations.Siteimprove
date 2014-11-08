using Newtonsoft.Json;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta2.Objects.Site {

    public class AnalyticsPopularPage {

        [JsonProperty("url")]
        public string Url { get; private set; }

        [JsonProperty("title")]
        public string Title { get; private set; }

        [JsonProperty("pageviews")]
        public int Pageviews { get; private set; }

        [JsonProperty("bounce_rate")]
        public float BounceRate { get; private set; }

        [JsonProperty("page_score")]
        public int PageScore { get; private set; }

        public static AnalyticsPopularPage Parse(JsonObject obj) {

            // Check if NULL
            if (obj == null) return null;

            return new AnalyticsPopularPage {
                Url = obj.GetString("url"),
                Title = obj.GetString("title"),
                Pageviews = obj.GetInt("pageviews"),
                BounceRate = obj.GetFloat("bounce_rate"),
                PageScore = obj.GetInt("page_score")
            };

        }

    }

}