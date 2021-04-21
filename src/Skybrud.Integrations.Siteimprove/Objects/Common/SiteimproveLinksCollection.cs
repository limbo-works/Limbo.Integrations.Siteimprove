using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Integrations.Siteimprove.Objects.Common {

    public class SiteimproveLinksCollection : SiteimproveObject {

        private readonly Dictionary<string, SiteimproveLinksCollection> _collections = new Dictionary<string, SiteimproveLinksCollection>();
        private readonly Dictionary<string, string> _links = new Dictionary<string, string>();

        #region Properties


        public Dictionary<string, SiteimproveLinksCollection> Collections {
            get { return _collections; }
        }

        public Dictionary<string, string> Links {
            get { return _links; }
        }

        #endregion

        #region Constructor

        protected SiteimproveLinksCollection(JObject obj) : base(obj) {
            foreach (JProperty property in obj.Properties()) {
                JToken value = property.Value;
                if (value.Type == JTokenType.String) {
                    _links.Add(property.Name, obj.GetString(property.Name));
                } else if (value.Type == JTokenType.Object) {
                    _collections.Add(property.Name, obj.GetObject(property.Name, Parse));
                }
            }
        }

        #endregion

        #region Member methods

        public bool HasCollection(string key) {
            return _collections.ContainsKey(key);
        }

        public bool HasLink(string key) {
            return _links.ContainsKey(key);
        }

        #endregion

        #region Static methods

        public static SiteimproveLinksCollection Parse(JObject obj) {
            return obj == null ? null : new SiteimproveLinksCollection(obj);
        }

        #endregion

    }

}