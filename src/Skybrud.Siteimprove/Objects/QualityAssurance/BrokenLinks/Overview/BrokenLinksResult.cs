using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Siteimprove.Objects.QualityAssurance.BrokenLinks.Overview {

    /// <summary>
    /// Describes the amount of broken links a specified time.
    /// </summary>
    public class BrokenLinksResult : SiteimproveObject {

        #region Properties










        /// <summary>
        /// Gets the amount of broken links.
        /// </summary>
        public int BrokenLinkCount { get; }

        /// <summary>
        /// Gets the amount of pages 
        /// </summary>
        public int PageCount { get; }

        /// <summary>
        /// Gets the UTC timestamp for the time the site was checked.
        /// </summary>
        public DateTime Timestamp { get; }

        #endregion

        #region Constructor

        private BrokenLinksResult(JObject obj) : base(obj) {
            BrokenLinkCount = obj.GetInt32("broken_link_count");
            PageCount = obj.GetInt32("page_count");
            Timestamp = obj.GetDateTime("timestamp");
        }

        #endregion

        #region Static methods

        public static BrokenLinksResult Parse(JObject obj) {
            return obj == null ? null : new BrokenLinksResult(obj);
        }

        #endregion

    }

}
