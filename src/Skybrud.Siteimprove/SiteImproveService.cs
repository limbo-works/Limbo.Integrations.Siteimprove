using Skybrud.Siteimprove.Endpoints;
using Skybrud.Siteimprove.Endpoints.Analytics;

namespace Skybrud.Siteimprove {
    
    public class SiteimproveService {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying client used for the raw communication.
        /// </summary>
        public SiteimproveClient Client { get; private set; }

        public SiteimproveSitesEndpoint Sites { get; private set; }

        public SiteimprovePagesEndpoint Pages { get; private set; }

        public SiteimproveAccessibilityEndpoint Accessibility { get; private set; }

        public SiteimproveAnalyticsEndpoint Analytics { get; private set; }

        public SiteimproveQualityAssuranceEndpoint QualityAssurance { get; private set; }
        
        #endregion

        #region Constructor

        private SiteimproveService() {
            Sites = new SiteimproveSitesEndpoint(this);
            Pages = new SiteimprovePagesEndpoint(this);
            Accessibility = new SiteimproveAccessibilityEndpoint(this);
            Analytics = new SiteimproveAnalyticsEndpoint(this);
            QualityAssurance = new SiteimproveQualityAssuranceEndpoint(this);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Initialize a new instance of <see cref="SiteimproveClient"/> based on values from the app settings.
        /// </summary>
        public static SiteimproveService CreateFromConfig() {
            return new SiteimproveService {
                Client = SiteimproveClient.CreateFromConfig()
            };
        }

        /// <summary>
        /// Initialize a new instance of <see cref="SiteimproveClient"/> from the specified client.
        /// </summary>
        /// <param name="client">The raw client to be used.</param>
        public static SiteimproveService CreateFromClient(SiteimproveClient client) {
            return new SiteimproveService {
                Client = client
            };
        }

        /// <summary>
        /// Initialize a new instance of <see cref="SiteimproveClient"/> from the specified username and password.
        /// </summary>
        /// <param name="username">The username of the Siteimprove account.</param>
        /// <param name="password">The password of the Siteimprove account.</param>
        public static SiteimproveService CreateFromCredentials(string username, string password) {
            return CreateFromClient(SiteimproveClient.CreateFromCredentials(username, password));
        }

        #endregion
        
    }

}
