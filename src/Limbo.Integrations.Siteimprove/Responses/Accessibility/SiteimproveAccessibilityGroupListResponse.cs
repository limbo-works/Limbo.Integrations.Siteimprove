using Limbo.Integrations.Siteimprove.Models.Accessibility.Groups;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Responses.Accessibility;

public class SiteimproveAccessibilityGroupListResponse : SiteimproveResponse<SiteimproveAccessibilityGroupList> {

    /// <summary>
    /// Initializes a new instance based on the specified <paramref name="response"/>.
    /// </summary>
    /// <param name="response">The underlying raw response the instance should be based on.</param>
    public SiteimproveAccessibilityGroupListResponse(IHttpResponse response) : base(response) {
        Body = ParseJsonObject(response.Body, SiteimproveAccessibilityGroupList.Parse);
    }

}