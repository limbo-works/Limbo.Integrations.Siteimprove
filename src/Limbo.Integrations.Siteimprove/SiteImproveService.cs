﻿using Limbo.Integrations.Siteimprove.Endpoints.Accessibility;
using Limbo.Integrations.Siteimprove.Endpoints.Analytics;
using Limbo.Integrations.Siteimprove.Endpoints.Content;
using Limbo.Integrations.Siteimprove.Endpoints.General;
using Limbo.Integrations.Siteimprove.Endpoints.QualityAssurance;
using Limbo.Integrations.Siteimprove.Http;

namespace Limbo.Integrations.Siteimprove {

    /// <summary>
    /// Class working as an entry point to making requests to the various endpoints of the Siteimprove API.
    /// </summary>
    public class SiteimproveService {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying client used for the raw communication.
        /// </summary>
        public SiteimproveHttpClient Client { get; private set; }

        /// <summary>
        /// Gets a reference to the <strong>Sites</strong> endpoint.
        /// </summary>
        public SiteimproveSitesEndpoint Sites { get; }

        /// <summary>
        /// Gets a reference to the <strong>Content</strong> endpoint.
        /// </summary>
        public SiteimproveContentEndpoint Content { get; }

        /// <summary>
        /// Gets a reference to the <strong>Accessibility</strong> endpoint.
        /// </summary>
        public SiteimproveAccessibilityEndpoint Accessibility { get; }

        /// <summary>
        /// Gets a reference to the <strong>Analytics</strong> endpoint.
        /// </summary>
        public SiteimproveAnalyticsEndpoint Analytics { get; }

        /// <summary>
        /// Gets a reference to the <strong>Quality Assurance</strong> endpoint.
        /// </summary>
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