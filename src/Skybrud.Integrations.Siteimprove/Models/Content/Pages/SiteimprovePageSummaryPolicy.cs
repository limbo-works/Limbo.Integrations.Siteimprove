using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Integrations.Siteimprove.Models.Content.Pages {
    
    public class SiteimprovePageSummaryPolicy : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the number of high priority policies matching this page.
        /// </summary>
        public int HighPriorityMatchingPolicies { get; }

        /// <summary>
        /// Gets the number of high priority policies currently being re-executed for this page. The results of each of
        /// these will be available as soon as the execution completes for each individual policy.
        /// </summary>
        public int HighPriorityPendingChecks { get; }

        /// <summary>
        /// Gets the number of high priority policies applicable for this page.
        /// </summary>
        public int HighPriorityPolicies { get; }

        /// <summary>
        /// Gets the number of policies matching this page.
        /// </summary>
        public int MatchingPolicies { get; }

        #endregion

        #region Constructors

        private SiteimprovePageSummaryPolicy(JObject obj) : base(obj) {
            HighPriorityMatchingPolicies = obj.GetInt32("high_priority_matching_policies");
            HighPriorityPendingChecks = obj.GetInt32("high_priority_pending_checks");
            HighPriorityPolicies = obj.GetInt32("high_priority_policies");
            MatchingPolicies = obj.GetInt32("matching_policies");
        }

        #endregion

        #region Static methods

        public static SiteimprovePageSummaryPolicy Parse(JObject obj) {
            return obj == null ? null : new SiteimprovePageSummaryPolicy(obj);
        }

        #endregion

    }

}