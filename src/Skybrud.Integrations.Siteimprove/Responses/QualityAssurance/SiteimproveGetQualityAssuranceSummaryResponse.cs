using System;
using Skybrud.Essentials.Http;
using Skybrud.Integrations.Siteimprove.Models.QualityAssurance;

namespace Skybrud.Integrations.Siteimprove.Responses.QualityAssurance {
    
    public class SiteimproveGetQualityAssuranceSummaryResponse : SiteimproveResponse<QualityAssuranceSummary> {

        #region Constructors

        private SiteimproveGetQualityAssuranceSummaryResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, QualityAssuranceSummary.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="SiteimproveGetQualityAssuranceSummaryResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveGetQualityAssuranceSummaryResponse"/>.</returns>
        public static SiteimproveGetQualityAssuranceSummaryResponse ParseResponse(IHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new SiteimproveGetQualityAssuranceSummaryResponse(response);

        }

        #endregion

    }

}