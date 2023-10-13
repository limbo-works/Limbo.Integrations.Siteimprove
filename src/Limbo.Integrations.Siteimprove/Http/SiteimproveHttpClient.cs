using System.Net;
using Limbo.Integrations.Siteimprove.Endpoints.Accessibility;
using Limbo.Integrations.Siteimprove.Endpoints.Analytics;
using Limbo.Integrations.Siteimprove.Endpoints.Content;
using Limbo.Integrations.Siteimprove.Endpoints.General;
using Limbo.Integrations.Siteimprove.Endpoints.QualityAssurance;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Client;

namespace Limbo.Integrations.Siteimprove.Http {

    /// <summary>
    /// HTTP client for making HTTP based requests to the Siteimprove API.
    /// </summary>
    public class SiteimproveHttpClient : HttpClient {

        #region Properties

        /// <summary>
        /// Gets or sets the credentials to be used for communicationg with the Siteimprove API.
        /// </summary>
        public NetworkCredential Crendentials { get; private set; }

        /// <summary>
        /// Gets a reference to the raw <strong>Sites</strong> endpoint.
        /// </summary>
        public SiteimproveSitesRawEndpoint Sites { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>Content</strong> endpoint.
        /// </summary>
        public SiteimproveContentRawEndpoint Content { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>Accessibility</strong> endpoint.
        /// </summary>
        public SiteimproveAccessibilityRawEndpoint Accessibility { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>Analytics</strong> endpoint.
        /// </summary>
        public SiteimproveAnalyticsRawEndpoint Analytics { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>Quality Assurance</strong> endpoint.
        /// </summary>
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

        /// <inheritdoc />
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