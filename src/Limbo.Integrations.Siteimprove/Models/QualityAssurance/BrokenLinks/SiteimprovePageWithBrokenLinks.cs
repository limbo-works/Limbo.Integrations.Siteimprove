using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace Limbo.Integrations.Siteimprove.Models.QualityAssurance.BrokenLinks {

    public class SiteimprovePageWithBrokenLinks : SiteimproveObject {

        #region Properties

        public long Id { get; }

        public string Title { get; }

        public string Url { get; }

        public int BrokenLinks { get; }

        public bool IsCheckingNow { get; }

        public string? CmsUrl { get; }

        public int PageLevel { get; }

        public float PageScore { get; }

        public int PageViews { get; }

        #endregion

        #region Constructors

        private SiteimprovePageWithBrokenLinks(JObject json) : base(json) {
            Id = json.GetInt64("id");
            Title = json.GetString("title")!;
            Url = json.GetString("url")!;
            BrokenLinks = json.GetInt32("broken_links");
            IsCheckingNow = json.GetBoolean("checking_now");
            CmsUrl = json.GetString("cms_url");
            PageLevel = json.GetInt32("page_level");
            PageScore = json.GetFloat("page_score");
            PageViews = json.GetInt32("page_views");
        }

        #endregion


        #region Static methods

        [return: NotNullIfNotNull("json")]
        public static SiteimprovePageWithBrokenLinks? Parse(JObject? json) {
            return json == null ? null : new SiteimprovePageWithBrokenLinks(json);
        }

        #endregion

    }

}