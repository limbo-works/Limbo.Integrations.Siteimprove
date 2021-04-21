using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Integrations.Siteimprove.Models.QualityAssurance.Spelling.Overview {
    
    public class SpellingCollection : SiteimproveObject {

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

        private SpellingCollection(JObject obj) : base(obj) {
            Items = obj.GetArrayItems("items", SpellingResult.Parse);
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
            Links = obj.GetObject("_links", LinkCollection.Parse);
            Siteimprove = obj.GetObject("_siteimprove", SiteimproveLinkCollection.Parse);
        }

        #endregion

        #region Static methods

        public static SpellingCollection Parse(JObject obj) {
            return obj == null ? null : new SpellingCollection(obj);
        }

        #endregion

        public class LinkCollection : SiteimproveObject {

            #region Properties

            [JsonProperty("prev")]
            public string Previous { get; private set; }

            [JsonProperty("next")]
            public string Next { get; private set; }

            #endregion

            #region Constructor

            private LinkCollection(JObject obj) : base(obj) {
                Previous = obj.GetString("prev");
                Next = obj.GetString("next");
            }

            #endregion

            #region Static methods

            public static LinkCollection Parse(JObject obj) {
                return obj == null ? null : new LinkCollection(obj);
            }

            #endregion

        }

        public class SiteimproveLinkCollection : SiteimproveObject {

            #region Properties

            [JsonProperty("webapp")]
            public string WebApp { get; private set; }

            #endregion

            #region Constructor

            private SiteimproveLinkCollection(JObject obj) : base(obj) {
                WebApp = obj.GetString("webapp");
            }

            #endregion

            #region Static methods

            public static SiteimproveLinkCollection Parse(JObject obj) {
                return obj == null ? null : new SiteimproveLinkCollection(obj);
            }

            #endregion

        }

    }

}