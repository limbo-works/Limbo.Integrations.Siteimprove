using System;
using Skybrud.Essentials.Common;
using Skybrud.Siteimprove.Options.QualityAssurance.BrokenLinks;
using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Endpoints.Raw {

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

        public SocialHttpResponse GetSummary(long siteId) {
            return GetSummary(new SiteimproveGetQualityAssuranceSummaryOptions(siteId));
        }

        public SocialHttpResponse GetSummary(long siteId, long groupId) {
            return GetSummary(new SiteimproveGetQualityAssuranceSummaryOptions(siteId, groupId));
        }

        public SocialHttpResponse GetSummary(SiteimproveGetQualityAssuranceSummaryOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            if (options.SiteId == 0) throw new PropertyNotSetException("options.SiteId");
            return Client.DoHttpGetRequest($"/v2/sites/{options.SiteId}/quality_assurance/overview/summary", options);
        }

        #endregion

    }

}