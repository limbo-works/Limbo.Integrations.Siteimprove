using System;
using Newtonsoft.Json.Linq;
using Skybrud.Siteimprove.Objects.Links;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Pages {

    public class SiteimprovePageSummary : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the number of page views in the last 7 days (if subscribed to Analytics).
        /// </summary>
        public int PageViews { get; private set; }

        /// <summary>
        /// Gets the Siteimprove page score for the page.
        /// </summary>
        public float PageScore { get; private set; }

        /// <summary>
        /// Gets the unique page identifier.
        /// </summary>
        public long PageId { get; private set; }

        /// <summary>
        /// Gets the title of the page as specified in the <code>&lt;title&gt;</code> element in the HTML.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Gets the URL of the page.
        /// </summary>
        public string Url { get; private set; }

        /// <summary>
        /// Gets the number of pages referring to this page.
        /// </summary>
        public int ReferringPagesCount { get; private set; }

        /// <summary>
        /// Gets the date and time of when this page was first seen in Siteimprove.
        /// </summary>
        public DateTime FirstSeen { get; private set; }

        /// <summary>
        /// Gets the size of the page in bytes.
        /// </summary>
        public int SizeBytes { get; private set; }

        public LinksCollection Links { get; private set; }

        #endregion

        #region Constructor

        private SiteimprovePageSummary(JObject obj) : base(obj) {
            PageViews = obj.GetInt32("page_views");
            PageScore = obj.GetFloat("page_score");
            PageId = obj.GetInt64("page_id");
            Title = obj.GetString("title");
            Url = obj.GetString("url");
            ReferringPagesCount = obj.GetInt32("page_score");
            FirstSeen = obj.GetString("first_seen", DateTime.Parse);
            SizeBytes = obj.GetInt32("size_bytes");
            Links = obj.GetObject("_links", LinksCollection.Parse);
        }

        #endregion

        #region Static methods

        public static SiteimprovePageSummary Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePageSummary(obj);
        }

        #endregion

    }

}