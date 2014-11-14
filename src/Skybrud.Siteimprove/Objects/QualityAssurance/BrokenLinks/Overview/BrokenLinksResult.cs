using System;
using Skybrud.Social;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Objects.QualityAssurance.BrokenLinks.Overview {

    /// <summary>
    /// Describes the amount of broken links a specified time.
    /// </summary>
    public class BrokenLinksResult : SocialJsonObject {

        #region Properties

        /// <summary>
        /// Gets the amount of broken links.
        /// </summary>
        public int BrokenLinkCount { get; private set; }

        /// <summary>
        /// Gets the amount of pages 
        /// </summary>
        public int PageCount { get; private set; }

        /// <summary>
        /// Gets the UTC timestamp for the time the site was checked.
        /// </summary>
        public DateTime Timestamp { get; private set; }

        #endregion

        #region Constructor

        private BrokenLinksResult(JsonObject obj) : base(obj) { }

        #endregion

        #region Static methods

        public static BrokenLinksResult Parse(JsonObject obj) {
            if (obj == null) return null;
            return new BrokenLinksResult(obj) {
                BrokenLinkCount = obj.GetInt32("broken_link_count"),
                PageCount = obj.GetInt32("page_count"),
                Timestamp = obj.GetDateTime("timestamp")
            };
        }

        #endregion

    }

}
