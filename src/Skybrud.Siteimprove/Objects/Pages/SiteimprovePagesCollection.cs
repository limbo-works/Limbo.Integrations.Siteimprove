using Newtonsoft.Json.Linq;

namespace Skybrud.Siteimprove.Objects.Pages {
    
    public class SiteimprovePagesCollection : SiteimproveObject {

        #region Properties
        
        #endregion

        #region Constructors

        private SiteimprovePagesCollection(JObject obj) : base(obj) {
            
        }

        #endregion

        #region Static methods

        public static SiteimprovePagesCollection Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePagesCollection(obj);
        }

        #endregion

    }

}