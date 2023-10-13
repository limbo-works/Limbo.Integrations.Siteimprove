using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.QualityAssurance.Spelling.Overview {

    public class SiteimproveSpellingResultList : SiteimproveObject {

        #region Properties

        [JsonProperty("items")]
        public IReadOnlyList<SiteimproveSpellingResult> Items { get; }

        [JsonProperty("total_items")]
        public int TotalItems { get; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; }

        [JsonProperty("_links")]
        public LinkCollection Links { get; }

        [JsonProperty("_siteimprove")]
        public SiteimproveLinkCollection Siteimprove { get; }

        #endregion

        #region Constructor

        private SiteimproveSpellingResultList(JObject obj) : base(obj) {
            Items = obj.GetArrayItems("items", SiteimproveSpellingResult.Parse)!;
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
            Links = obj.GetObject("_links", LinkCollection.Parse)!;
            Siteimprove = obj.GetObject("_siteimprove", SiteimproveLinkCollection.Parse)!;
        }

        #endregion

        #region Static methods

        [return: NotNullIfNotNull("obj")]
        public static SiteimproveSpellingResultList? Parse(JObject? obj) {
            return obj == null ? null : new SiteimproveSpellingResultList(obj);
        }

        #endregion

        public class LinkCollection : SiteimproveObject {

            #region Properties

            [JsonProperty("prev")]
            public string? Previous { get; }

            [JsonProperty("next")]
            public string? Next { get; }

            #endregion

            #region Constructor

            private LinkCollection(JObject obj) : base(obj) {
                Previous = obj.GetString("prev");
                Next = obj.GetString("next");
            }

            #endregion

            #region Static methods

            [return: NotNullIfNotNull("obj")]
            public static LinkCollection? Parse(JObject? obj) {
                return obj == null ? null : new LinkCollection(obj);
            }

            #endregion

        }

        public class SiteimproveLinkCollection : SiteimproveObject {

            #region Properties

            [JsonProperty("webapp")]
            public string WebApp { get; }

            #endregion

            #region Constructor

            private SiteimproveLinkCollection(JObject obj) : base(obj) {
                WebApp = obj.GetString("webapp")!;
            }

            #endregion

            #region Static methods

            [return: NotNullIfNotNull("obj")]
            public static SiteimproveLinkCollection? Parse(JObject? obj) {
                return obj == null ? null : new SiteimproveLinkCollection(obj);
            }

            #endregion

        }

    }

}