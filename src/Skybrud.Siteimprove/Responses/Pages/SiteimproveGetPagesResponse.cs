using System;
using Skybrud.Siteimprove.Objects.Content;
using Skybrud.Siteimprove.Objects.Content.Pages;
using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Responses.Pages {
    
    public class SiteimproveGetPagesResponse : SiteimproveResponse<SiteimprovePagesCollection> {

        #region Constructors

        private SiteimproveGetPagesResponse(SocialHttpResponse response) : base(response) {

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
        public static SiteimproveGetPagesResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new SiteimproveGetPagesResponse(response);

        }

        #endregion

    }

}