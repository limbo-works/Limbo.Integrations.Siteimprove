using Limbo.Integrations.Siteimprove.Models.QualityAssurance;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Responses.QualityAssurance {

    public class SiteimproveQualityAssuranceSummaryResponse : SiteimproveResponse<SiteimproveQualityAssuranceSummary> {

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        public SiteimproveQualityAssuranceSummaryResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, SiteimproveQualityAssuranceSummary.Parse);
        }

    }

}