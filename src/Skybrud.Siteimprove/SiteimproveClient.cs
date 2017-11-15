using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Net;
using Skybrud.Siteimprove.Endpoints.Analytics.Raw;
using Skybrud.Siteimprove.Endpoints.Raw;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces;

namespace Skybrud.Siteimprove {
    
    public class SiteimproveClient {

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

        /// <summary>
        /// Make a HTTP GET request to the specified URL.
        /// </summary>
        /// <param name="url">The URL of the request.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse DoHttpGetRequest(string url) {
            return DoHttpGetRequest(url, default(NameValueCollection));
        }

        /// <summary>
        /// Make a HTTP GET request to the specified URL.
        /// </summary>
        /// <param name="url">The URL of the request.</param>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse DoHttpGetRequest(string url, IGetOptions options) {
            if (String.IsNullOrWhiteSpace(url)) throw new ArgumentNullException("url");
            if (options == null) throw new ArgumentNullException("options");
            return DoHttpGetRequest(url, options.GetQueryString());
        }

        /// <summary>
        /// Make a HTTP GET request to the specified URL.
        /// </summary>
        /// <param name="url">The URL of the request.</param>
        /// <param name="query">The query string of the request.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse DoHttpGetRequest(string url, NameValueCollection query) {

            // Some input validation
            if (String.IsNullOrWhiteSpace(url)) throw new ArgumentNullException("url");

            // Append the scheme and host (if not already specified)
            if (url.StartsWith("/")) url = "https://api.siteimprove.com" + url;

            // Intitialize the request
            SocialHttpRequest request = new SocialHttpRequest {
                Method = "GET",
                Url = url,
                Accept = "application/json",
                QueryString = query,
                Credentials = Crendentials
            };

            // Make the call to the API
            return request.GetResponse();

        }

        /// <summary>
        /// Make a HTTP GET request to the specified URL.
        /// </summary>
        /// <param name="url">The URL of the request.</param>
        /// <param name="query">The query string of the request.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse DoHttpGetRequest(string url, SocialQueryString query) {
            return DoHttpGetRequest(url, query == null ? null : query.NameValueCollection);
        }

        #endregion

    }

}
