using Limbo.Integrations.Siteimprove.Models.QualityAssurance.BrokenLinks.Overview;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Responses.QualityAssurance.BrokenLinks;

public class SiteimproveBrokenLinksResponse : SiteimproveResponse<SiteimproveBrokenLinksResultList> {

    /// <summary>
    /// Initializes a new instance based on the specified <paramref name="response"/>.
    /// </summary>
    /// <param name="response">The underlying raw response the instance should be based on.</param>
    public SiteimproveBrokenLinksResponse(IHttpResponse response) : base(response) {
        Body = ParseJsonObject(response.Body, SiteimproveBrokenLinksResultList.Parse);
    }

}