using Newtonsoft.Json.Linq;

namespace Skybrud.Siteimprove.Objects.Pages {
    
    public class SiteimprovePage : SiteimproveObject {

        #region Properties
        
        #endregion

        #region Constructors

        private SiteimprovePage(JObject obj) : base(obj) {
            
        }

        #endregion

        #region Static methods

        public static SiteimprovePage Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePage(obj);
        }

        #endregion

    }

}