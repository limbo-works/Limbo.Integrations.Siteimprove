using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Integrations.Siteimprove.Objects.Content.Pages {

    public class SiteimprovePageItem : SiteimproveObject {

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
        /// Gets the URL of the page.
        /// </summary>
        public string Url { get; }
        
        #endregion

        #region Constructors

        private SiteimprovePageItem(JObject obj) : base(obj) {
            Id = obj.GetInt64("id");
            Title = obj.GetString("title");
            Url = obj.GetString("url");
        }

        #endregion

        #region Static methods

        public static SiteimprovePageItem Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePageItem(obj);
        }

        #endregion

    }

}