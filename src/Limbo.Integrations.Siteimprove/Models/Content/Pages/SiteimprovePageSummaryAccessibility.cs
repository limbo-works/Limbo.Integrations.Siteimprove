using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.Content.Pages {

    public class SiteimprovePageSummaryAccessibility : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the number of A errors on the page.
        /// </summary>
        public int AErrors { get; }

        /// <summary>
        /// Gets the number of A issues on the page.
        /// </summary>
        public int AIssues { get; }

        /// <summary>
        /// Gets the number of A warnings on the page.
        /// </summary>
        public int AWarnings { get; }

        /// <summary>
        /// Gets the number of AA errors on the page.
        /// </summary>
        public int AaErrors { get; }

        /// <summary>
        /// Gets the number of AA issues on the page.
        /// </summary>
        public int AaIssues { get; }

        /// <summary>
        /// Gets the number of AA warnings on the page.
        /// </summary>
        public int AaWarnings { get; }

        /// <summary>
        /// Gets the number of AAA errors on the page.
        /// </summary>
        public int AaaErrors { get; }

        /// <summary>
        /// Gets the number of AAA issues on the page.
        /// </summary>
        public int AaaIssues { get; }

        /// <summary>
        /// Gets the number of AAA warnings on the page.
        /// </summary>
        public int AaaWarnings { get; }

        #endregion

        #region Constructors

        private SiteimprovePageSummaryAccessibility(JObject obj) : base(obj) {

            AErrors = obj.GetInt32("a_errors");
            AIssues = obj.GetInt32("a_issues");
            AWarnings = obj.GetInt32("a_warnings");

            AaErrors = obj.GetInt32("aa_errors");
            AaIssues = obj.GetInt32("aa_issues");
            AaWarnings = obj.GetInt32("aa_warnings");

            AaaErrors = obj.GetInt32("aaa_errors");
            AaaIssues = obj.GetInt32("aaa_issues");
            AaaWarnings = obj.GetInt32("aaa_warnings");

        }

        #endregion

        #region Static methods

        public static SiteimprovePageSummaryAccessibility Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePageSummaryAccessibility(obj);
        }

        #endregion

    }

}