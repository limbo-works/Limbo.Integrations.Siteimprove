using Limbo.Integrations.Siteimprove.Models.Analytics.Overview;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Responses.Analytics.Overview;

public class SiteimproveAnalyticsSummaryResponse : SiteimproveResponse<SiteimproveAnalyticsSite> {

    /// <summary>
    /// Initializes a new instance based on the specified <paramref name="response"/>.
    /// </summary>
    /// <param name="response">The underlying raw response the instance should be based on.</param>
    public SiteimproveAnalyticsSummaryResponse(IHttpResponse response) : base(response) {
        Body = ParseJsonObject(response.Body, SiteimproveAnalyticsSite.Parse);
    }

}