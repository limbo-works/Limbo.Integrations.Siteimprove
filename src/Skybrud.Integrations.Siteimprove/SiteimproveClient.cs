using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Net;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Client;
using Skybrud.Integrations.Siteimprove.Endpoints.Analytics.Raw;
using Skybrud.Integrations.Siteimprove.Endpoints.Raw;

namespace Skybrud.Integrations.Siteimprove {
    
    public class SiteimproveClient : HttpClient {

        public const string ApiUrl = "https://api.siteimprove.com/v1/";
        public const string ApiUrlV2 = "https://api.siteimprove.com/v2/";

        #region Properties

        public NetworkCredential Crendentials { get; private set; }

        public SiteimproveSitesRawEndpoint Sites { get; private set; }
        
        public SiteimproveContentRawEndpoint Content { get; private set; }
        
        public SiteimproveAnalyticsRawEndpoint Analytics { get; private set; }
        
        public SiteimproveAccessibilityRawEndpoint Accessibility { get; private set; }
        
        public SiteimproveQualityAssuranceRawEndpoint QualityAssurance { get; private set; }

        #endregion

        #region Constructor

        private SiteimproveClient() {
            Sites = new SiteimproveSitesRawEndpoint(this);
            Content = new SiteimproveContentRawEndpoint(this);
            Accessibility = new SiteimproveAccessibilityRawEndpoint(this);
            Analytics = new SiteimproveAnalyticsRawEndpoint(this);
            QualityAssurance = new SiteimproveQualityAssuranceRawEndpoint(this);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Initialize a new instance of <see cref="SiteimproveClient"/> based on values from the app settings.
        /// </summary>
        public static SiteimproveClient CreateFromConfig() {
            string username = ConfigurationManager.AppSettings["SiteimproveUsername"];
            string password = ConfigurationManager.AppSettings["SiteimprovePassword"];
            return new SiteimproveClient {
                Crendentials = new NetworkCredential(username, password)
            };
        }

        /// <summary>
        /// Initialize a new instance of <see cref="SiteimproveClient"/> from the specified username and password.
        /// </summary>
        /// <param name="username">The username of the Siteimprove account.</param>
        /// <param name="password">The password of the Siteimprove account.</param>
        public static SiteimproveClient CreateFromCredentials(string username, string password) {
            return new SiteimproveClient {
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