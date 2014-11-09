using System.Collections.Specialized;
using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Beta2.Endpoints.Raw {

    public class SiteimprovePagesRawEndpoint {

        public SiteimproveClient Client { get; private set; }

        internal SiteimprovePagesRawEndpoint(SiteimproveClient client) {
            Client = client;
        }

        public SocialHttpResponse GetPage(int siteId, string url) {
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrl + "/" + siteId + "/Page", new NameValueCollection {
                {"url", url}
            });
        }

    }

}