using Newtonsoft.Json;
using Skybrud.Social;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Objects.QualityAssurance.Spelling.Overview {
    
    public class SpellingCollection : SocialJsonObject {

        #region Properties

        [JsonProperty("items")]
        public SpellingResult[] Items { get; private set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; private set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; private set; }

        [JsonProperty("_links")]
        public LinkCollection Links { get; private set; }

        [JsonProperty("_siteimprove")]
        public SiteimproveLinkCollection Siteimprove { get; private set; }

        #endregion

        #region Constructor

        private SpellingCollection(JsonObject obj) : base(obj) { }

        #endregion

        #region Static methods

        public static SpellingCollection Parse(JsonObject obj) {
            if (obj == null) return null;
            return new SpellingCollection(obj) {
                Items = obj.GetArray("items", SpellingResult.Parse),
                TotalItems = obj.GetInt32("total_items"),
                TotalPages = obj.GetInt32("total_pages"),
                Links = obj.GetObject("_links", LinkCollection.Parse),
                Siteimprove = obj.GetObject("_siteimprove", SiteimproveLinkCollection.Parse)
            };
        }

        #endregion

        public class LinkCollection : SocialJsonObject {

            #region Properties

            [JsonProperty("prev")]
            public string Previous { get; private set; }

            [JsonProperty("next")]
            public string Next { get; private set; }

            #endregion

            #region Constructor

            private LinkCollection(JsonObject obj) : base(obj) { }

            #endregion

            #region Static methods

            public static LinkCollection Parse(JsonObject obj) {
                if (obj == null) return null;
                return new LinkCollection(obj) {
                    Previous = obj.GetString("prev"),
                    Next = obj.GetString("next")
                };
            }

            #endregion

        }

        public class SiteimproveLinkCollection : SocialJsonObject {

            #region Properties

            [JsonProperty("webapp")]
            public string WebApp { get; private set; }

            #endregion

            #region Constructor

            private SiteimproveLinkCollection(JsonObject obj) : base(obj) { }

            #endregion

            #region Static methods

            public static SiteimproveLinkCollection Parse(JsonObject obj) {
                if (obj == null) return null;
                return new SiteimproveLinkCollection(obj) {
                    WebApp = obj.GetString("webapp")
                };
            }

            #endregion

        }

    }

}