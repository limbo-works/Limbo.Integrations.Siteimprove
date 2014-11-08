using Skybrud.Social;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta1 {
    
    public class SiteimproveService {

        #region Properties

        public SiteimproveRawClient Client { get; private set; }
        
        #endregion

        #region Constructor

        private SiteimproveService() {
            // Hide default constructor
        }

        #endregion

        #region Static methods
        
        public static SiteimproveService CreateFromConfig() {
            return new SiteimproveService {
                Client = SiteimproveRawClient.CreateFromConfig()
            };
        }
        
        public static SiteimproveService CreateFromClient(SiteimproveRawClient client) {
            return new SiteimproveService {
                Client = client
            };
        }

        public static SiteimproveService CreateFromCredentials(string username, string password) {
            return CreateFromClient(SiteimproveRawClient.CreateFromCredentials(username, password));
        }

        #endregion

        #region Member methods

        public SiteimproveSiteSummary[] GetSites() {
            string response = Client.GetSites();
            return JsonArray.ParseJson(response, SiteimproveSiteSummary.ParseMultiple);
        }

        public SiteimproveSite GetSite(int siteId) {
            return SiteimproveSite.ParseJson(Client.GetSite(siteId));
        }

        public SiteimprovePage GetPage(int siteId, string url) {

            // Make the call to the API
            SocialHttpResponse response = Client.GetPage(siteId, url);

            // Parse the response
            return SiteimprovePage.ParseJson(response.GetBodyAsString());
        
        }

        #endregion

    }

}
