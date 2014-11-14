using Newtonsoft.Json;
using Skybrud.Social;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Objects {
    
    public class SiteimproveSite : SocialJsonObject {

        #region Properties
        
        [JsonProperty("site_id")]
        public int Id { get; private set; }
        
        [JsonProperty("site_name")]
        public string Name { get; private set; }
        
        [JsonProperty("url")]
        public string Url { get; private set; }

        [JsonProperty("page_count")]
        public int PageCount { get; private set; }

        [JsonProperty("_links")]
        public LinkCollection Links { get; private set; }
        
        #endregion

        #region Constructor

        private SiteimproveSite(JsonObject obj) : base(obj) { }

        #endregion

        #region Static methods

        public static SiteimproveSite Parse(JsonObject obj) {
            if (obj == null) return null;
            return new SiteimproveSite(obj) {
                Id = obj.GetInt32("site_id"),
                Name = obj.GetString("site_name"),
                Url = obj.GetString("url"),
                PageCount = obj.GetInt32("page_count"),
                Links = obj.GetObject("_links", LinkCollection.Parse)
            };
        }

        #endregion

        public class LinkCollection : SocialJsonObject {

            #region Properties

            [JsonProperty("accessibility")]
            public AccessibilityLinkCollection Accessibility { get; private set; }

            [JsonProperty("quality_assurance")]
            public QualityAssuranceLinkCollection QualityAssurance { get; private set; }

            [JsonProperty("pages")]
            public string Pages { get; private set; }

            #endregion

            #region Constructor

            private LinkCollection(JsonObject obj) : base(obj) { }

            #endregion

            #region Static methods

            public static LinkCollection Parse(JsonObject obj) {
                if (obj == null) return null;
                return new LinkCollection(obj) {
                    Accessibility = obj.GetObject("accessibility", AccessibilityLinkCollection.Parse),
                    QualityAssurance = obj.GetObject("quality_assurance", QualityAssuranceLinkCollection.Parse),
                    Pages = obj.GetString("pages")
                };
            }

            #endregion

        }

        public class AccessibilityLinkCollection : SocialJsonObject {

            #region Properties

            [JsonProperty("overview")]
            public string Overview { get; set; }

            [JsonProperty("issues")]
            public string Issues { get; set; }

            [JsonProperty("pages")]
            public string Pages { get; set; }

            #endregion

            #region Constructor

            private AccessibilityLinkCollection(JsonObject obj) : base(obj) { }

            #endregion

            #region Static methods

            public static AccessibilityLinkCollection Parse(JsonObject obj) {
                if (obj == null) return null;
                return new AccessibilityLinkCollection(obj) {
                    Overview = obj.GetString("overview"),
                    Issues = obj.GetString("issues"),
                    Pages = obj.GetString("pages")
                };
            }

            #endregion

        }

        public class QualityAssuranceLinkCollection : SocialJsonObject {

            #region Properties

            [JsonProperty("broken_links")]
            public BrokenLinksLinkCollection BrokenLinks { get; set; }

            [JsonProperty("spelling")]
            public SpellingLinkCollection Spelling { get; set; }

            #endregion

            #region Constructor

            private QualityAssuranceLinkCollection(JsonObject obj) : base(obj) { }

            #endregion

            #region Static methods

            public static QualityAssuranceLinkCollection Parse(JsonObject obj) {
                if (obj == null) return null;
                return new QualityAssuranceLinkCollection(obj) {
                    BrokenLinks = obj.GetObject("broken_links", BrokenLinksLinkCollection.Parse),
                    Spelling = obj.GetObject("spelling", SpellingLinkCollection.Parse)
                };
            }

            #endregion

        }

        public class BrokenLinksLinkCollection : SocialJsonObject {

            #region Properties

            [JsonProperty("overview")]
            public string Overview { get; set; }

            [JsonProperty("links")]
            public string Links { get; set; }

            [JsonProperty("pages")]
            public string Pages { get; set; }

            #endregion

            #region Constructor

            private BrokenLinksLinkCollection(JsonObject obj) : base(obj) { }

            #endregion

            #region Static methods

            public static BrokenLinksLinkCollection Parse(JsonObject obj) {
                if (obj == null) return null;
                return new BrokenLinksLinkCollection(obj) {
                    Overview = obj.GetString("overview"),
                    Links = obj.GetString("links"),
                    Pages = obj.GetString("pages")
                };
            }

            #endregion

        }

        public class SpellingLinkCollection : SocialJsonObject {

            #region Properties

            [JsonProperty("overview")]
            public string Overview { get; set; }

            [JsonProperty("pages")]
            public string Pages { get; set; }

            [JsonProperty("misspellings")]
            public string Misspellings { get; set; }

            [JsonProperty("potential_misspellings")]
            public string PotentialMisspellings { get; set; }

            #endregion

            #region Constructor

            private SpellingLinkCollection(JsonObject obj) : base(obj) { }

            #endregion

            #region Static methods

            public static SpellingLinkCollection Parse(JsonObject obj) {
                if (obj == null) return null;
                return new SpellingLinkCollection(obj) {
                    Overview = obj.GetString("overview"),
                    Pages = obj.GetString("pages"),
                    Misspellings = obj.GetString("misspellings"),
                    PotentialMisspellings = obj.GetString("potential_misspellings")
                };
            }

            #endregion

        }
    
    }

}
