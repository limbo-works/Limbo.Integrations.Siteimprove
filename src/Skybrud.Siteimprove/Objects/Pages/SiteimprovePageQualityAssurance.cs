using Newtonsoft.Json.Linq;
using Skybrud.Siteimprove.Objects.Common;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Pages {
    
    public class SiteimprovePageQualityAssurance : SiteimproveObject {

        #region Properties

        public int BrokenLinkCount { get; private set; }

        public int WordCount { get; private set; }

        public int MisspellingCount { get; private set; }

        public int PotentialMisspellingCount { get; private set; }

        public SiteimproveWebLinksCollection Siteimprove { get; private set; }

        public SiteimprovePageQualityAssuranceLinksCollection Links { get; private set; }

        #endregion

        #region Constructor

        private SiteimprovePageQualityAssurance(JObject obj) : base(obj) {
            BrokenLinkCount = obj.GetInt32("broken_link_count");
            WordCount = obj.GetInt32("word_count");
            MisspellingCount = obj.GetInt32("misspelling_count");
            PotentialMisspellingCount = obj.GetInt32("potential_misspelling_count");
            Siteimprove = obj.GetObject("_siteimprove", SiteimproveWebLinksCollection.Parse);
            Links = obj.GetObject("_links", SiteimprovePageQualityAssuranceLinksCollection.Parse);
        }

        #endregion

        #region Static methods

        public static SiteimprovePageQualityAssurance Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePageQualityAssurance(obj);
        }

        #endregion

    }

}