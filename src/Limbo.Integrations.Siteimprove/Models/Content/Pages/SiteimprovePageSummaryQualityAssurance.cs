using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace Limbo.Integrations.Siteimprove.Models.Content.Pages {

    public class SiteimprovePageSummaryQualityAssurance : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the number of clicks on the broken link for this page.
        /// </summary>
        public int BrokenLinks { get; }

        /// <summary>
        /// Gets the number of misspellings for this page.
        /// </summary>
        public int Misspellings { get; }

        /// <summary>
        /// Gets number of potential misspellings for this page.
        /// </summary>
        public int PotentialMisspellings { get; }

        /// <summary>
        /// Gets the number of pages referring to this page.
        /// </summary>
        public int ReferringPages { get; }

        #endregion

        #region Constructors

        private SiteimprovePageSummaryQualityAssurance(JObject obj) : base(obj) {
            BrokenLinks = obj.GetInt32("broken_links");
            Misspellings = obj.GetInt32("misspellings");
            PotentialMisspellings = obj.GetInt32("potential_misspellings");
            ReferringPages = obj.GetInt32("referring_pages");
        }

        #endregion

        #region Static methods

        [return: NotNullIfNotNull("obj")]
        public static SiteimprovePageSummaryQualityAssurance? Parse(JObject? obj) {
            return obj == null ? null : new SiteimprovePageSummaryQualityAssurance(obj);
        }

        #endregion

    }

}