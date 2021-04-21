using System;
using Skybrud.Essentials.Http;
using Skybrud.Integrations.Siteimprove.Models.QualityAssurance.BrokenLinks.Overview;

namespace Skybrud.Integrations.Siteimprove.Responses.QualityAssurance.BrokenLinks {
    
    public class SiteimproveGetBrokenLinksResponse : SiteimproveResponse<BrokenLinksCollection> {

        #region Constructors

        private SiteimproveGetBrokenLinksResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, BrokenLinksCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="SiteimproveGetBrokenLinksResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="SiteimproveGetBrokenLinksResponse"/>.</returns>
        public static SiteimproveGetBrokenLinksResponse ParseResponse(IHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new SiteimproveGetBrokenLinksResponse(response);

        }

        #endregion

    }

}