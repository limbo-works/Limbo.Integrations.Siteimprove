using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Endpoints.Raw {

    public class SiteimproveAccessibilityRawEndpoint {

        #region Properties

        public SiteimproveClient Client { get; private set; }

        #endregion

        #region Constructor

        internal SiteimproveAccessibilityRawEndpoint(SiteimproveClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a overview for accessibility.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        public SocialHttpResponse GetOverview(int siteId) {
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrl + "sites/" + siteId + "/accessibility");
        }

        #endregion

    }

}