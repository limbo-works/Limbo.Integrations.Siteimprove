using Skybrud.Integrations.Siteimprove.Options.QualityAssurance.BrokenLinks;
using Skybrud.Integrations.Siteimprove.Responses.QualityAssurance;

namespace Skybrud.Integrations.Siteimprove.Endpoints.QualityAssurance {

    public class SiteimproveQualityAssuranceEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveQualityAssuranceRawEndpoint Raw => Service.Client.QualityAssurance;

        public SiteimproveBrokenLinksEndpoint BrokenLinks { get; }

        public SiteimproveSpellingEndpoint Spelling { get; }

        #endregion

        #region Constructors

        internal SiteimproveQualityAssuranceEndpoint(SiteimproveService service) {
            Service = service;
            BrokenLinks = new SiteimproveBrokenLinksEndpoint(service);
            Spelling = new SiteimproveSpellingEndpoint(service);
        }

        #endregion

        #region Member methods

        public SiteimproveQualityAssuranceSummaryResponse GetSummary(long siteId) {
            return new SiteimproveQualityAssuranceSummaryResponse(Raw.GetSummary(siteId));
        }

        public SiteimproveQualityAssuranceSummaryResponse GetSummary(long siteId, long groupId) {
            return new SiteimproveQualityAssuranceSummaryResponse(Raw.GetSummary(siteId, groupId));
        }

        public SiteimproveQualityAssuranceSummaryResponse GetSummary(SiteimproveGetQualityAssuranceSummaryOptions options) {
            return new SiteimproveQualityAssuranceSummaryResponse(Raw.GetSummary(options));
        }

        #endregion

    }

}