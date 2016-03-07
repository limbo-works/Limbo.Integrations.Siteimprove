using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Sites {
    
    public class SiteimproveSite : SiteimproveObject {

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

        private SiteimproveSite(JObject obj) : base(obj) {
            Id = obj.GetInt32("site_id");
            Name = obj.GetString("site_name");
            Url = obj.GetString("url");
            PageCount = obj.GetInt32("page_count");
            Links = obj.GetObject("_links", LinkCollection.Parse);
        }

        #endregion

        #region Static methods

        public static SiteimproveSite Parse(JObject obj) {
            return obj == null ? null : new SiteimproveSite(obj);
        }

        #endregion

        public class LinkCollection : SiteimproveObject {

            #region Properties

            [JsonProperty("accessibility")]
            public AccessibilityLinkCollection Accessibility { get; private set; }

            [JsonProperty("quality_assurance")]
            public QualityAssuranceLinkCollection QualityAssurance { get; private set; }

            [JsonProperty("pages")]
            public string Pages { get; private set; }

            #endregion

            #region Constructor

            private LinkCollection(JObject obj) : base(obj) {
                Accessibility = obj.GetObject("accessibility", AccessibilityLinkCollection.Parse);
                QualityAssurance = obj.GetObject("quality_assurance", QualityAssuranceLinkCollection.Parse);
                Pages = obj.GetString("pages");
            }

            #endregion

            #region Static methods

            public static LinkCollection Parse(JObject obj) {
                return obj == null ? null : new LinkCollection(obj);
            }

            #endregion

        }

        public class AccessibilityLinkCollection : SiteimproveObject {

            #region Properties

            [JsonProperty("overview")]
            public string Overview { get; set; }

            [JsonProperty("issues")]
            public string Issues { get; set; }

            [JsonProperty("pages")]
            public string Pages { get; set; }

            #endregion

            #region Constructor

            private AccessibilityLinkCollection(JObject obj) : base(obj) {
                Overview = obj.GetString("overview");
                Issues = obj.GetString("issues");
                Pages = obj.GetString("pages");
            }

            #endregion

            #region Static methods

            public static AccessibilityLinkCollection Parse(JObject obj) {
                return obj == null ? null : new AccessibilityLinkCollection(obj);
            }

            #endregion

        }

        public class QualityAssuranceLinkCollection : SiteimproveObject {

            #region Properties

            [JsonProperty("broken_links")]
            public BrokenLinksLinkCollection BrokenLinks { get; set; }

            [JsonProperty("spelling")]
            public SpellingLinkCollection Spelling { get; set; }

            #endregion

            #region Constructor

            private QualityAssuranceLinkCollection(JObject obj) : base(obj) {
                BrokenLinks = obj.GetObject("broken_links", BrokenLinksLinkCollection.Parse);
                Spelling = obj.GetObject("spelling", SpellingLinkCollection.Parse);
            }

            #endregion

            #region Static methods

            public static QualityAssuranceLinkCollection Parse(JObject obj) {
                return obj == null ? null : new QualityAssuranceLinkCollection(obj);
            }

            #endregion

        }

        public class BrokenLinksLinkCollection : SiteimproveObject {

            #region Properties

            [JsonProperty("overview")]
            public string Overview { get; set; }

            [JsonProperty("links")]
            public string Links { get; set; }

            [JsonProperty("pages")]
            public string Pages { get; set; }

            #endregion

            #region Constructor

            private BrokenLinksLinkCollection(JObject obj) : base(obj) {
                Overview = obj.GetString("overview");
                Links = obj.GetString("links");
                Pages = obj.GetString("pages");
            }

            #endregion

            #region Static methods

            public static BrokenLinksLinkCollection Parse(JObject obj) {
                return obj == null ? null : new BrokenLinksLinkCollection(obj);
            }

            #endregion

        }

        public class SpellingLinkCollection : SiteimproveObject {

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

            private SpellingLinkCollection(JObject obj) : base(obj) {
                Overview = obj.GetString("overview");
                Pages = obj.GetString("pages");
                Misspellings = obj.GetString("misspellings");
                PotentialMisspellings = obj.GetString("potential_misspellings");
            }

            #endregion

            #region Static methods

            public static SpellingLinkCollection Parse(JObject obj) {
                return obj == null ? null : new SpellingLinkCollection(obj);
            }

            #endregion

        }
    
    }

}
