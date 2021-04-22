using Skybrud.Essentials.Http;
using Skybrud.Integrations.Siteimprove.Models.Content.Pages;

namespace Skybrud.Integrations.Siteimprove.Responses.Pages {
    
    public class SiteimprovePageListResponse : SiteimproveResponse<SiteimprovePagesCollection> {

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        public SiteimprovePageListResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, SiteimprovePagesCollection.Parse);
        }

    }

}