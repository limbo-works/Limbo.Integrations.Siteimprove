using System;
using Skybrud.Essentials.Http;
using Skybrud.Integrations.Siteimprove.Models.Content.Pages;

namespace Skybrud.Integrations.Siteimprove.Responses.Pages {
    
    public class SiteimproveGetPagesResponse : SiteimproveResponse<SiteimprovePagesCollection> {

        #region Constructors

        private SiteimproveGetPagesResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SiteimprovePagesCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SiteimproveGetPagesResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveGetPagesResponse"/>.</returns>
        public static SiteimproveGetPagesResponse ParseResponse(IHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new SiteimproveGetPagesResponse(response);

        }

        #endregion

    }

}