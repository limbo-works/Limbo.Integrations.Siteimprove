using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Siteimprove.Objects.Common;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Pages {

    public class SiteimprovePagesLinksCollection : SiteimproveLinksCollection {

        #region Properties

        /// <summary>
        /// Gets the URL for the previous page.
        /// </summary>
        [JsonProperty("prev")]
        public string Previous { get; private set; }

        /// <summary>
        /// Gets the URL for the next page.
        /// </summary>
        [JsonProperty("next")]
        public string Next { get; private set; }

        /// <summary>
        /// Gets whether there is a previous page.
        /// </summary>
        [JsonIgnore]
        public bool HasPrevious {
            get { return !String.IsNullOrWhiteSpace(Previous); }
        }

        /// <summary>
        /// Gets whether there is a next page.
        /// </summary>
        [JsonIgnore]
        public bool HasNext {
            get { return !String.IsNullOrWhiteSpace(Next); }
        }

        #endregion

        #region Constructor

        private SiteimprovePagesLinksCollection(JObject obj) : base(obj) {
            Previous = obj.GetString("prev");
            Next = obj.GetString("next");
        }

        #endregion

        #region Static methods

        public static SiteimprovePagesLinksCollection Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePagesLinksCollection(obj);
        }

        #endregion

    }

}