using Skybrud.Essentials.Http;
using Skybrud.Integrations.Siteimprove.Models.QualityAssurance.BrokenLinks;

namespace Skybrud.Integrations.Siteimprove.Responses.QualityAssurance.BrokenLinks {
    
    public class SiteimprovePageWithBrokenLinksListResponse : SiteimproveResponse<SiteimprovePageWithBrokenLinksList> {

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        public SiteimprovePageWithBrokenLinksListResponse(IHttpResponse response) : base(response) {
            ValidateResponse(response);
            Body = ParseJsonObject(response.Body, SiteimprovePageWithBrokenLinksList.Parse);
        }

    }

}