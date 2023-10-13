using Newtonsoft.Json.Linq;

namespace Limbo.Integrations.Siteimprove.Models.Sites {
    
    public class SiteimproveSite : SiteimproveSiteItem {

        #region Constructors

        protected SiteimproveSite(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        public new static SiteimproveSite Parse(JObject obj) {
            return obj == null ? null : new SiteimproveSite(obj);
        }

        #endregion
    
    }

}