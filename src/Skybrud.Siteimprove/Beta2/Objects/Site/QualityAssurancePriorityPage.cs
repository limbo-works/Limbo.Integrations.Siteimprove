using Newtonsoft.Json;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta2.Objects.Site {

    public class QualityAssurancePriorityPage {

        [JsonProperty("url")]
        public string Url { get; private set; }

        [JsonProperty("title")]
        public string Title { get; private set; }

        [JsonProperty("page_report_url")]
        public string PageReportUrl { get; private set; }

        [JsonProperty("broken_links")]
        public int BrokenLinks { get; private set; }

        [JsonProperty("misspellings")]
        public int Misspellings { get; private set; }

        [JsonProperty("pageviews")]
        public int Pageviews { get; private set; }

        [JsonProperty("page_level")]
        public int PageLevel { get; private set; }

        public static QualityAssurancePriorityPage Parse(JsonObject obj) {
            if (obj == null) return null;
            return new QualityAssurancePriorityPage {
                Url = obj.GetString("url"),
                Title = obj.GetString("title"),
                PageReportUrl = obj.GetString("page_report_url"),
                BrokenLinks = obj.GetInt("broken_links"),
                Misspellings = obj.GetInt("misspellings"),
                Pageviews = obj.HasValue("pageviews") ? obj.GetInt("pageviews") : 0,
                PageLevel = obj.GetInt("page_level")
            };
        }

    }

}