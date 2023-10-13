using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.Common {

    public class SiteimproveLinksCollection : SiteimproveObject {

        private readonly Dictionary<string, SiteimproveLinksCollection> _collections = new();
        private readonly Dictionary<string, string> _links = new();

        #region Properties


        public Dictionary<string, SiteimproveLinksCollection> Collections => _collections;

        public Dictionary<string, string> Links => _links;

        #endregion

        #region Constructor

        protected SiteimproveLinksCollection(JObject obj) : base(obj) {
            foreach (JProperty property in obj.Properties()) {
                JToken value = property.Value;
                if (value.Type == JTokenType.String) {
                    _links.Add(property.Name, obj.GetString(property.Name)!);
                } else if (value.Type == JTokenType.Object) {
                    _collections.Add(property.Name, obj.GetObject(property.Name, Parse)!);
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

        [return: NotNullIfNotNull("obj")]
        public static SiteimproveLinksCollection? Parse(JObject? obj) {
            return obj == null ? null : new SiteimproveLinksCollection(obj);
        }

        #endregion

    }

}