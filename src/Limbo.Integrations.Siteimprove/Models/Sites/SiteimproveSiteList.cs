using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.Sites {

    public class SiteimproveSiteList : SiteimproveObject {

        #region Properties

        public int TotalItems { get; }

        public int TotalPages { get; }

        public SiteimproveSiteItem[] Items { get; }

        #endregion

        #region Constructors

        private SiteimproveSiteList(JObject obj) : base(obj) {
            Items = obj.GetArray("items", SiteimproveSiteItem.Parse);
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
        }

        #endregion

        #region Static methods

        public static SiteimproveSiteList Parse(JObject obj) {
            return obj == null ? null : new SiteimproveSiteList(obj);
        }

        #endregion

    }

}