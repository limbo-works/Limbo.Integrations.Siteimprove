//using Newtonsoft.Json;
//using Skybrud.Social;
//using Skybrud.Social.Json;

//namespace Skybrud.Siteimprove.Objects {

//    public class SiteimproveSitesCollection : SocialJsonObject {

//        #region Properties

//        [JsonProperty("items")]
//        public SiteimproveSiteSummary[] Items { get; private set; }

//        [JsonProperty("total_items")]
//        public int TotalItems { get; private set; }

//        [JsonProperty("total_pages")]
//        public int TotalPages { get; private set; }

//        [JsonProperty("_links")]
//        public LinkCollection Links { get; private set; }

//        #endregion

//        #region Constructor

//        private SiteimproveSitesCollection(JsonObject obj) : base(obj) { }

//        #endregion

//        #region Static methods

//        public static SiteimproveSitesCollection Parse(JsonObject obj) {
//            if (obj == null) return null;
//            return new SiteimproveSitesCollection(obj) {
//                Items = obj.GetArray("items", SiteimproveSiteSummary.Parse),
//                TotalItems = obj.GetInt32("total_items"),
//                TotalPages = obj.GetInt32("total_pages"),
//                Links = obj.GetObject("_links", LinkCollection.Parse)
//            };
//        }

//        #endregion

//        public class LinkCollection : SocialJsonObject {

//            #region Properties

//            [JsonProperty("prev")]
//            public string Previous { get; private set; }

//            [JsonProperty("next")]
//            public string Next { get; private set; }

//            #endregion

//            #region Constructor

//            private LinkCollection(JsonObject obj) : base(obj) { }

//            #endregion

//            #region Static methods

//            public static LinkCollection Parse(JsonObject obj) {
//                if (obj == null) return null;
//                return new LinkCollection(obj) {
//                    Previous = obj.GetString("prev"),
//                    Next = obj.GetString("next")
//                };
//            }

//            #endregion

//        }

//    }

//}
