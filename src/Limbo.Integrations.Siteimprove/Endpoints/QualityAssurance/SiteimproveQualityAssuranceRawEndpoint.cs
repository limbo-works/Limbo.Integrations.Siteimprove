using System;
using Limbo.Integrations.Siteimprove.Http;
using Limbo.Integrations.Siteimprove.Options.QualityAssurance.BrokenLinks;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Endpoints.QualityAssurance {

    public class SiteimproveQualityAssuranceRawEndpoint {

        #region Properties

        public SiteimproveHttpClient Client { get; }

        public SiteimproveBrokenLinksRawEndpoint BrokenLinks { get; }

        public SiteimproveSpellingRawEndpoint Spelling { get; }

        #endregion

        #region Constructor

        internal SiteimproveQualityAssuranceRawEndpoint(SiteimproveHttpClient client) {
            Client = client;
            BrokenLinks = new SiteimproveBrokenLinksRawEndpoint(client);
            Spelling = new SiteimproveSpellingRawEndpoint(client);
        }

        #endregion

        #region Member methods

        public IHttpResponse GetSummary(long siteId) {
            return GetSummary(new SiteimproveGetQualityAssuranceSummaryOptions(siteId));
        }

        public IHttpResponse GetSummary(long siteId, long groupId) {
            return GetSummary(new SiteimproveGetQualityAssuranceSummaryOptions(siteId, groupId));
        }

        public IHttpResponse GetSummary(SiteimproveGetQualityAssuranceSummaryOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        #endregion

    }

}