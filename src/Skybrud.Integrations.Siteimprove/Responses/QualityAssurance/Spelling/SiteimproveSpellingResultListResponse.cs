using Skybrud.Essentials.Http;
using Skybrud.Integrations.Siteimprove.Models.QualityAssurance.Spelling.Overview;

namespace Skybrud.Integrations.Siteimprove.Responses.QualityAssurance.Spelling {
    
    public class SiteimproveSpellingResultListResponse : SiteimproveResponse<SiteimproveSpellingResultList> {

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        public SiteimproveSpellingResultListResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, SiteimproveSpellingResultList.Parse);
        }

    }

}