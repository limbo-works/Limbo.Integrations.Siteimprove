using Limbo.Integrations.Siteimprove.Models.Analytics.Behavior;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Responses.Analytics.Behavior;

public class SiteimproveAnalyticsVisitLengthResponse : SiteimproveResponse<SiteimproveAnalyticsVisitLengthGraphList> {

    /// <summary>
    /// Initializes a new instance based on the specified <paramref name="response"/>.
    /// </summary>
    /// <param name="response">The underlying raw response the instance should be based on.</param>
    public SiteimproveAnalyticsVisitLengthResponse(IHttpResponse response) : base(response) {
        Body = ParseJsonObject(response.Body, SiteimproveAnalyticsVisitLengthGraphList.Parse);
    }

}