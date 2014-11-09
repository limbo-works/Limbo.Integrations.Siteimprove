namespace Skybrud.Siteimprove {
    
    public class SiteimproveService {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying client used for the raw communication.
        /// </summary>
        public SiteimproveClient Client { get; private set; }
        
        #endregion

        #region Constructor

        private SiteimproveService() { }

        #endregion

        #region Static methods

        /// <summary>
        /// Initialize a new instance of <code>SiteimproveRawClient</code> based on values from the app settings.
        /// </summary>
        public static SiteimproveService CreateFromConfig() {
            return new SiteimproveService {
                Client = SiteimproveClient.CreateFromConfig()
            };
        }

        /// <summary>
        /// Initialize a new instance of <code>SiteimproveRawClient</code> from the specified client.
        /// </summary>
        /// <param name="client">The raw client to be used.</param>
        public static SiteimproveService CreateFromClient(SiteimproveClient client) {
            return new SiteimproveService {
                Client = client
            };
        }

        /// <summary>
        /// Initialize a new instance of <code>SiteimproveRawClient</code> from the specified username and password.
        /// </summary>
        /// <param name="username">The username of the Siteimprove account.</param>
        /// <param name="password">The password of the Siteimprove account.</param>
        public static SiteimproveService CreateFromCredentials(string username, string password) {
            return CreateFromClient(SiteimproveClient.CreateFromCredentials(username, password));
        }

        #endregion

        #region Member methods

        ///// <summary>
        ///// Get a list of all sites on the account that you have access to.
        ///// </summary>
        //public SiteimproveSitesResponse GetSites() {
        //    return SiteimproveSitesResponse.Parse(Client.Sites.GetSites());
        //}

        ///// <summary>
        ///// Get a list of all sites on the account that you have access to.
        ///// </summary>
        //public SiteimproveSitesResponse GetSites(int offset) {
        //    return SiteimproveSitesResponse.Parse(Client.Sites.GetSites(offset));
        //}

        ///// <summary>
        ///// Gets informations about the site with the specified <code>siteId</code>.
        ///// </summary>
        ///// <param name="siteId">The ID of the site.</param>
        ///// <returns></returns>
        //public SiteimproveSite GetSite(int siteId) {
        //    return SiteimproveSite.Parse(Client.Sites.GetSite(siteId));
        //}

        //public SiteimprovePage GetPage(int siteId, string url) {

        //    // Make the call to the API
        //    SocialHttpResponse response = Client.GetPage(siteId, url);

        //    // Parse the response
        //    return SiteimprovePage.ParseJson(response.GetBodyAsString());
        
        //}

        #endregion

    }

}
