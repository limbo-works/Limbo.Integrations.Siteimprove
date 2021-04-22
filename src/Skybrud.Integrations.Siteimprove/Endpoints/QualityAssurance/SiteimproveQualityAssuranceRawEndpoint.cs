using System;
using Skybrud.Essentials.Http;
using Skybrud.Integrations.Siteimprove.Options.QualityAssurance.BrokenLinks;

namespace Skybrud.Integrations.Siteimprove.Endpoints.QualityAssurance {

    public class SiteimproveQualityAssuranceRawEndpoint {

        #region Properties

        public SiteimproveClient Client { get; }

        public SiteimproveBrokenLinksRawEndpoint BrokenLinks { get; }

        public SiteimproveSpellingRawEndpoint Spelling { get; }

        #endregion

        #region Constructor

        internal SiteimproveQualityAssuranceRawEndpoint(SiteimproveClient client) {
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