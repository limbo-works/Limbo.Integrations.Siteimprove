﻿using Newtonsoft.Json.Linq;

namespace Skybrud.Siteimprove.Objects.Sites {
    
    public class SiteimproveSite : SiteimproveSiteSummary {

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