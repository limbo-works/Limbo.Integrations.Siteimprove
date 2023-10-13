using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.QualityAssurance.Spelling {
    
    public class SiteimprovePageWithSpellingErrors : SiteimproveObject {

        #region Properties

        public long Id { get; }

        public string Title { get; }

        public string Url { get; }

        public bool IsCheckingNow { get; }

        public string CmsUrl { get; }

        public int Misspellings { get; }

        public int PageLevel { get; }

        public float PageScore { get; }

        public int PageViews { get; }

        public int PotentialMisspellings { get; }

        #endregion

        #region Constructors

        private SiteimprovePageWithSpellingErrors(JObject json) : base(json) {
            Id = json.GetInt64("id");
            Title = json.GetString("title");
            Url = json.GetString("url");
            IsCheckingNow = json.GetBoolean("checking_now");
            CmsUrl = json.GetString("cms_url");
            Misspellings = json.GetInt32("misspellings");
            PageLevel = json.GetInt32("page_level");
            PageScore = json.GetFloat("page_score");
            PageViews = json.GetInt32("page_views");
            PotentialMisspellings = json.GetInt32("potential_misspellings");
        }

        #endregion

        #region Static methods

        public static SiteimprovePageWithSpellingErrors Parse(JObject json) {
            return json == null ? null : new SiteimprovePageWithSpellingErrors(json);
        }

        #endregion

    }

}