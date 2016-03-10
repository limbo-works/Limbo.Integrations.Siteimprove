using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Siteimprove.Objects.Common;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Pages {

    public class SiteimprovePageQualityAssuranceLinksCollection : SiteimproveLinksCollection {

        #region Properties

        [JsonProperty("potential_misspellings")]
        public string PotentialMisspellings { get; private set; }

        [JsonProperty("broken_links")]
        public string BrokenLinks { get; private set; }

        #endregion

        #region Constructor

        private SiteimprovePageQualityAssuranceLinksCollection(JObject obj) : base(obj) {
            PotentialMisspellings = obj.GetString("potential_misspellings");
            BrokenLinks = obj.GetString("broken_links");
        }

        #endregion

        #region Static methods

        public static SiteimprovePageQualityAssuranceLinksCollection Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePageQualityAssuranceLinksCollection(obj);
        }

        #endregion

    }

}