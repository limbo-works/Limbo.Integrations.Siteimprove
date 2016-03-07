using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Sites {
    
    public class SiteimproveSitesCollection : SiteimproveObject {

        #region Properties

        public int TotalItems { get; private set; }

        public int TotalPages { get; private set; }

        public SiteimproveSiteSummary[] Items { get; private set; }

        #endregion

        #region Constructors

        private SiteimproveSitesCollection(JObject obj) : base(obj) {
            Items = obj.GetArray("items", SiteimproveSiteSummary.Parse);
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
        }

        #endregion

        #region Static methods

        public static SiteimproveSitesCollection Parse(JObject obj) {
            return obj == null ? null : new SiteimproveSitesCollection(obj);
        }

        #endregion

    }

}