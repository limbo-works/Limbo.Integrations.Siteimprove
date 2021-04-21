using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Integrations.Siteimprove.Models.Content.Pages {
    
    public class SiteimprovePage : SiteimproveObject {

        #region Properties
        
        /// <summary>
        /// Gets the ID of the page.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Gets the title of the page as specified in the <code>&lt;title&gt;</code> element in the HTML.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the  for the live version of the page.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Gets the URL for the cms entry for editing the page.
        /// </summary>
        public string CmsUrl { get; }

        /// <summary>
        /// Gets the size of the page in bytes.
        /// </summary>
        public int SizeBytes { get; }

        /// <summary>
        /// Gets a summary of data for the page.
        /// </summary>
        public SiteimprovePageSummary Summary { get; }

        public SiteimprovePageWebLinkCollection WebLinks { get; }

        #endregion

        #region Constructors

        private SiteimprovePage(JObject obj) : base(obj) {
            Id = obj.GetInt64("id");
            Title = obj.GetString("title");
            Url = obj.GetString("url");
            CmsUrl = obj.GetString("cms_url");
            SizeBytes = obj.GetInt32("size_bytes");
            Summary = obj.GetObject("summary", SiteimprovePageSummary.Parse);
            WebLinks = obj.GetObject("_siteimprove", SiteimprovePageWebLinkCollection.Parse);
        }

        #endregion

        #region Static methods

        public static SiteimprovePage Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePage(obj);
        }

        #endregion

    }

}