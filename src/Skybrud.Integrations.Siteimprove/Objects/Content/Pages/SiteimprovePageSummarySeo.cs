using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Integrations.Siteimprove.Objects.Content.Pages {
    
    public class SiteimprovePageSummarySeo : SiteimproveObject {

        #region Properties

        public int Errors { get; }

        public int NeedsReview { get; }

        public int Warnings { get; }

        #endregion

        #region Constructors

        private SiteimprovePageSummarySeo(JObject obj) : base(obj) {
            Errors = obj.GetInt32("errors");
            NeedsReview = obj.GetInt32("needs_review");
            Warnings = obj.GetInt32("warnings");
        }

        #endregion

        #region Static methods

        public static SiteimprovePageSummarySeo Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePageSummarySeo(obj);
        }

        #endregion

    }

}