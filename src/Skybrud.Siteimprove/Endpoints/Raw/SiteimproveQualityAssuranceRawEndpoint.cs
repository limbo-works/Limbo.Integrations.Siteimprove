namespace Skybrud.Siteimprove.Endpoints.Raw {

    public class SiteimproveQualityAssuranceRawEndpoint {

        #region Properties

        public SiteimproveClient Client { get; private set; }

        public SiteimproveBrokenLinksRawEndpoint BrokenLinks { get; private set; }

        public SiteimproveSpellingRawEndpoint Spelling { get; private set; }

        #endregion

        #region Constructor

        internal SiteimproveQualityAssuranceRawEndpoint(SiteimproveClient client) {
            Client = client;
            BrokenLinks = new SiteimproveBrokenLinksRawEndpoint(client);
            Spelling = new SiteimproveSpellingRawEndpoint(client);
        }

        #endregion

    }

}