using System.Collections.Generic;
using Newtonsoft.Json;
using Skybrud.Social;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Objects.Links {

    public class LinksCollection : SocialJsonObject {

        #region Properties

        [JsonProperty("webapp")]
        public string WebApp { get; private set; }

        #endregion

        private Dictionary<string, LinksCollection> _collections = new Dictionary<string, LinksCollection>();
        private Dictionary<string, string> _links = new Dictionary<string, string>();

        public Dictionary<string, LinksCollection> Collections {
            get { return _collections; }
        }

        public Dictionary<string, string> Links {
            get { return _links; }
        }

        private LinksCollection(JsonObject obj) : base(obj) {
            WebApp = obj.GetString("webapp");
        }

        public static LinksCollection Parse(JsonObject obj) {
            LinksCollection collection = new LinksCollection(obj);
            foreach (string key in obj.Keys) {
                if (obj.Dictionary[key] is string) {
                    collection._links.Add(key, obj.GetString(key));
                } else {
                    collection._collections.Add(key, obj.GetObject(key, Parse));
                }
            }
            return collection;
        }

        public bool HasCollection(string key) {
            return _collections.ContainsKey(key);
        }

        public bool HasLink(string key) {
            return _links.ContainsKey(key);
        }
    
    }

}
