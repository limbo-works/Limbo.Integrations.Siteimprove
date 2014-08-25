using System.Collections.Specialized;
using Skybrud.Siteimprove.Skybrud.Social;

namespace Skybrud.Siteimprove.Beta2.Endpoints.Raw {

    public class SiteimproveSitesRawEndpoint {

        public SiteimproveClient Client { get; private set; }

        internal SiteimproveSitesRawEndpoint(SiteimproveClient client) {
            Client = client;
        }

        /// <summary>
        /// Get a list of all pages on a site.
        /// </summary>
        public SocialHttpResponse GetSites() {
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrl + "/sites");
        }

        /// <summary>
        /// Get a list of all pages on a site.
        /// </summary>
        /// <param name="offset">Specify an offset when fetching more pages.</param>
        public SocialHttpResponse GetSites(int offset) {
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrl + "/sites", new NameValueCollection {
                {"offset", offset + ""}
            });
        }

        public SocialHttpResponse GetSite(int siteId) {
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrl + "/sites/" + siteId);
        }

    }

}