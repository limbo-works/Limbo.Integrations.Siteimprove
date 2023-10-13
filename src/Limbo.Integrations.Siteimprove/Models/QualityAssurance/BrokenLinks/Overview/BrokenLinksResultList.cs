using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.QualityAssurance.BrokenLinks.Overview {

    public class SiteimproveBrokenLinksResultList : SiteimproveObject {

        #region Properties

        [JsonProperty("items")]
        public SiteimproveBrokenLinksResult[] Items { get; }

        [JsonProperty("total_items")]
        public int TotalItems { get; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; }

        [JsonProperty("_links")]
        public LinkCollection Links { get; }

        [JsonProperty("_siteimprove")]
        public SiteimproveLinkCollection Siteimprove { get; }

        #endregion

        #region Constructors

        private SiteimproveBrokenLinksResultList(JObject obj) : base(obj) {
            Items = obj.GetArrayItems("items", SiteimproveBrokenLinksResult.Parse);
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
            Links = obj.GetObject("_links", LinkCollection.Parse);
            Siteimprove = obj.GetObject("_siteimprove", SiteimproveLinkCollection.Parse);
        }

        #endregion

        #region Static methods

        public static SiteimproveBrokenLinksResultList Parse(JObject obj) {
            return obj == null ? null : new SiteimproveBrokenLinksResultList(obj);
        }

        #endregion

        public class SiteimproveLinkCollection : SiteimproveObject {

            #region Properties

            [JsonProperty("prev")]
            public string Previous { get; }

            [JsonProperty("next")]
            public string Next { get; }

            #endregion

            #region Constructors

            private SiteimproveLinkCollection(JObject obj) : base(obj) {
                Previous = obj.GetString("prev");
                Next = obj.GetString("next");
            }

            #endregion

            #region Static methods

            public static SiteimproveLinkCollection Parse(JObject obj) {
                return obj == null ? null : new SiteimproveLinkCollection(obj);
            }

            #endregion

        }

        public class LinkCollection : SiteimproveObject {

            #region Properties

            [JsonProperty("webapp")]
            public string WebApp { get; }

            #endregion

            #region Constructors

            private LinkCollection(JObject obj) : base(obj) {
                WebApp = obj.GetString("webapp");
            }

            #endregion

            #region Static methods

            public static LinkCollection Parse(JObject obj) {
                return obj == null ? null : new LinkCollection(obj);
            }

            #endregion

        }

    }

}