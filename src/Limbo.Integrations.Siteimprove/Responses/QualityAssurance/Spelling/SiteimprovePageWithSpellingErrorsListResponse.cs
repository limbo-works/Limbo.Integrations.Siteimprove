using Limbo.Integrations.Siteimprove.Models.QualityAssurance.Spelling;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Responses.QualityAssurance.Spelling {

    public class SiteimprovePageWithSpellingErrorsListResponse : SiteimproveResponse<SiteimprovePageWithSpellingErrorsList> {

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        public SiteimprovePageWithSpellingErrorsListResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, SiteimprovePageWithSpellingErrorsList.Parse);
        }

    }

}