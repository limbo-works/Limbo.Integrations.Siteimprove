using System.Configuration;
using System.Net;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Client;
using Skybrud.Integrations.Siteimprove.Endpoints.Accessibility;
using Skybrud.Integrations.Siteimprove.Endpoints.Analytics;
using Skybrud.Integrations.Siteimprove.Endpoints.Content;
using Skybrud.Integrations.Siteimprove.Endpoints.General;
using Skybrud.Integrations.Siteimprove.Endpoints.QualityAssurance;

namespace Skybrud.Integrations.Siteimprove.Http {
    
    public class SiteimproveHttpClient : HttpClient {

        #region Properties

        public NetworkCredential Crendentials { get; private set; }

        public SiteimproveSitesRawEndpoint Sites { get; }
        
        public SiteimproveContentRawEndpoint Content { get; }
        
        public SiteimproveAnalyticsRawEndpoint Analytics { get; }
        
        public SiteimproveAccessibilityRawEndpoint Accessibility { get; }
        
        public SiteimproveQualityAssuranceRawEndpoint QualityAssurance { get; }

        #endregion

        #region Constructor

        private SiteimproveHttpClient() {
            Sites = new SiteimproveSitesRawEndpoint(this);
            Content = new SiteimproveContentRawEndpoint(this);
            Accessibility = new SiteimproveAccessibilityRawEndpoint(this);
            Analytics = new SiteimproveAnalyticsRawEndpoint(this);
            QualityAssurance = new SiteimproveQualityAssuranceRawEndpoint(this);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Initialize a new instance of <see cref="SiteimproveHttpClient"/> based on values from the app settings.
        /// </summary>
        public static SiteimproveHttpClient CreateFromConfig() {
            string username = ConfigurationManager.AppSettings["SiteimproveUsername"];
            string password = ConfigurationManager.AppSettings["SiteimprovePassword"];
            return new SiteimproveHttpClient {
                Crendentials = new NetworkCredential(username, password)
            };
        }

        /// <summary>
        /// Initialize a new instance of <see cref="SiteimproveHttpClient"/> from the specified username and password.
        /// </summary>
        /// <param name="username">The username of the Siteimprove account.</param>
        /// <param name="password">The password of the Siteimprove account.</param>
        public static SiteimproveHttpClient CreateFromCredentials(string username, string password) {
            return new SiteimproveHttpClient {
                Crendentials = new NetworkCredential(username, password)
            };
        }

        #endregion

        #region Member methods
        
        protected override void PrepareHttpRequest(IHttpRequest request) {

            // Append the scheme and host (if not already specified)
            if (request.Url.StartsWith("/")) request.Url = "https://api.siteimprove.com" + request.Url;

            // Append the accept header
            if (string.IsNullOrWhiteSpace(request.Accept)) request.Accept = "application/json";

            // Set the credentials
            if (Crendentials != null) request.Credentials = Crendentials;

        }

        #endregion

    }

}