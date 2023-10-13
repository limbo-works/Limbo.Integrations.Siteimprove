using Limbo.Integrations.Siteimprove.Models.Accessibility.Pages;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Responses.Accessibility.Pages {

    public class SiteimproveAccessibilityPageIssuesListResponse : SiteimproveResponse<SiteimproveAccessibilityPageIssuesList> {

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        public SiteimproveAccessibilityPageIssuesListResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, SiteimproveAccessibilityPageIssuesList.Parse);
        }

    }

}