using Limbo.Integrations.Siteimprove.Models.Analytics.Content;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Responses.Analytics.Content {

    public class SiteimproveAnalyticsPopularPageListResponse : SiteimproveResponse<SiteimproveAnalyticsPopularPageList> {

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        public SiteimproveAnalyticsPopularPageListResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, SiteimproveAnalyticsPopularPageList.Parse);
        }

    }

}