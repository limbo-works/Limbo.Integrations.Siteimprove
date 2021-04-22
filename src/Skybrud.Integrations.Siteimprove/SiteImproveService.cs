using Skybrud.Integrations.Siteimprove.Endpoints.Accessibility;
using Skybrud.Integrations.Siteimprove.Endpoints.Analytics;
using Skybrud.Integrations.Siteimprove.Endpoints.Content;
using Skybrud.Integrations.Siteimprove.Endpoints.General;
using Skybrud.Integrations.Siteimprove.Endpoints.QualityAssurance;
using Skybrud.Integrations.Siteimprove.Http;

namespace Skybrud.Integrations.Siteimprove {
    
    public class SiteimproveService {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying client used for the raw communication.
        /// </summary>
        public SiteimproveHttpClient Client { get; private set; }

        public SiteimproveSitesEndpoint Sites { get; }

        public SiteimproveContentEndpoint Content { get; }

        public SiteimproveAccessibilityEndpoint Accessibility { get; }

        public SiteimproveAnalyticsEndpoint Analytics { get; }

        public SiteimproveQualityAssuranceEndpoint QualityAssurance { get; }
        
        #endregion

        #region Constructor

        private SiteimproveService() {
            Sites = new SiteimproveSitesEndpoint(this);
            Content = new SiteimproveContentEndpoint(this);
            Accessibility = new SiteimproveAccessibilityEndpoint(this);
            Analytics = new SiteimproveAnalyticsEndpoint(this);
            QualityAssurance = new SiteimproveQualityAssuranceEndpoint(this);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Initialize a new instance of <see cref="SiteimproveHttpClient"/> based on values from the app settings.
        /// </summary>
        public static SiteimproveService CreateFromConfig() {
            return new SiteimproveService {
                Client = SiteimproveHttpClient.CreateFromConfig()
            };
        }

        /// <summary>
        /// Initialize a new instance of <see cref="SiteimproveHttpClient"/> from the specified client.
        /// </summary>
        /// <param name="client">The raw client to be used.</param>
        public static SiteimproveService CreateFromClient(SiteimproveHttpClient client) {
            return new SiteimproveService {
                Client = client
            };
        }

        /// <summary>
        /// Initialize a new instance of <see cref="SiteimproveHttpClient"/> from the specified username and password.
        /// </summary>
        /// <param name="username">The username of the Siteimprove account.</param>
        /// <param name="password">The password of the Siteimprove account.</param>
        public static SiteimproveService CreateFromCredentials(string username, string password) {
            return CreateFromClient(SiteimproveHttpClient.CreateFromCredentials(username, password));
        }

        #endregion
        
    }

}