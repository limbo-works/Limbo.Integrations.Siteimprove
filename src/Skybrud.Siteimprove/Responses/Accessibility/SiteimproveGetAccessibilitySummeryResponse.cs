using System;
using Skybrud.Siteimprove.Objects.Accessibility;
using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Responses.Accessibility {

    public class SiteimproveGetAccessibilitySummeryResponse : SiteimproveResponse<AccessibilitySummaryCollection> {

        #region Constructors

        private SiteimproveGetAccessibilitySummeryResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, AccessibilitySummaryCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SiteimproveGetAccessibilitySummeryResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveGetAccessibilitySummeryResponse"/>.</returns>
        public static SiteimproveGetAccessibilitySummeryResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new SiteimproveGetAccessibilitySummeryResponse(response);

        }

        #endregion

    }

}