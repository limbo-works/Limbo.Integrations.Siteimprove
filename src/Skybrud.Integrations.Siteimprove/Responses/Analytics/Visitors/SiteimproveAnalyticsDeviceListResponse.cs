using Skybrud.Essentials.Http;
using Skybrud.Integrations.Siteimprove.Models.Analytics.Visitors;

namespace Skybrud.Integrations.Siteimprove.Responses.Analytics.Visitors {

    public class SiteimproveAnalyticsDeviceListResponse : SiteimproveResponse<SiteimproveAnalyticsDeviceList> {

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        public SiteimproveAnalyticsDeviceListResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, SiteimproveAnalyticsDeviceList.Parse);
        }

    }

}