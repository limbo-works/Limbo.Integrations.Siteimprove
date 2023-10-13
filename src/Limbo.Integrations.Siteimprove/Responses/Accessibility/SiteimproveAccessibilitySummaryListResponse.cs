using Limbo.Integrations.Siteimprove.Models.Accessibility;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Responses.Accessibility {

    public class SiteimproveAccessibilitySummaryListResponse : SiteimproveResponse<SiteimproveAccessibilitySummaryList> {

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        public SiteimproveAccessibilitySummaryListResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, SiteimproveAccessibilitySummaryList.Parse);
        }

    }

}