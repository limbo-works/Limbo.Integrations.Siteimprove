using System.Configuration;
using System.Net;
using Skybrud.Social;

namespace Skybrud.Siteimprove.Beta1 {
    
    public class SiteimproveRawClient {

        #region Properties

        public NetworkCredential Crendentials { get; private set; }
        
        #endregion

        #region Constructor

        private SiteimproveRawClient() {
            // Hide default constructor
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Initialize a new instance of <code>SiteimproveRawClient</code> based on values from the app settings.
        /// </summary>
        public static SiteimproveRawClient CreateFromConfig() {
            string username = ConfigurationManager.AppSettings["SiteimproveUsername"];
            string password = ConfigurationManager.AppSettings["SiteimprovePassword"];
            return new SiteimproveRawClient {
                Crendentials = new NetworkCredential(username, password)
            };
        }

        /// <summary>
        /// Initialize a new instance of <code>SiteimproveRawClient</code> from the specified username and password.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public static SiteimproveRawClient CreateFromCredentials(string username, string password) {
            return new SiteimproveRawClient {
                Crendentials = new NetworkCredential(username, password)
            };
        }

        #endregion

        #region Member methods

        public string GetSites() {

            SocialHttpRequest request = new SocialHttpRequest {
                Url = "http://api.siteimprove.com/beta/api/Site?type=json",
                Credentials = Crendentials
            };

            // Make the call to the API
            return request.GetResponse().GetBodyAsString();

        }

        public string GetSite(int siteId) {

            SocialHttpRequest request = new SocialHttpRequest {
                Url = "http://api.siteimprove.com/beta/api/" + siteId + "/Site?type=json",
                Credentials = Crendentials
            };

            // Make the call to the API
            return request.GetResponse().GetBodyAsString();

        }

        public SocialHttpResponse GetPage(int siteId, string url) {

            SocialHttpRequest request = new SocialHttpRequest {
                Url = "http://api.siteimprove.com/beta/api/" + siteId + "/Page?type=json&url=" + url,
                Credentials = Crendentials
            };

            // Make the call to the API
            return request.GetResponse();

        }

        #endregion

    }

}
