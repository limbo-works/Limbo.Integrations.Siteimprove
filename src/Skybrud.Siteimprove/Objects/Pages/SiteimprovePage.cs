using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Pages {
    
    public class SiteimprovePage : SiteimproveObject {

        #region Properties

        public bool IsCheckingNow { get; private set; }

        public long PageId { get; private set; }

        public string Title { get; private set; }

        public string Url { get; private set; }

        public SiteimprovePageQualityAssurance QualityAssurance { get; private set; }

        public SiteimprovePageAccessibility Accessibility { get; private set; }
        
        #endregion

        #region Constructors

        private SiteimprovePage(JObject obj) : base(obj) {
            IsCheckingNow = obj.GetBoolean("checking_now");
            PageId = obj.GetInt64("page_id");
            Title = obj.GetString("title");
            Url = obj.GetString("url");
            QualityAssurance = obj.GetObject("quality_assurance", SiteimprovePageQualityAssurance.Parse);
            Accessibility = obj.GetObject("accessibility", SiteimprovePageAccessibility.Parse);
        }

        #endregion

        #region Static methods

        public static SiteimprovePage Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePage(obj);
        }

        #endregion

    }

}