using System;
using Skybrud.Integrations.Siteimprove.Models.Accessibility;
using Skybrud.Social.Http;

namespace Skybrud.Integrations.Siteimprove.Responses.Accessibility {

    public class SiteimproveGetAccessibilitySummaryResponse : SiteimproveResponse<AccessibilitySummaryCollection> {

        #region Constructors

        private SiteimproveGetAccessibilitySummaryResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, AccessibilitySummaryCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SiteimproveGetAccessibilitySummaryResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveGetAccessibilitySummaryResponse"/>.</returns>
        public static SiteimproveGetAccessibilitySummaryResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new SiteimproveGetAccessibilitySummaryResponse(response);

        }

        #endregion

    }

}