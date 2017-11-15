using System;
using Skybrud.Siteimprove.Objects.Accessibility.Pages;
using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Responses.Accessibility.Pages {

    public class SiteimproveGetPageAccessibilityIssuesResponse : SiteimproveResponse<PageAccessibilityIssuesCollection> {

        #region Constructors

        private SiteimproveGetPageAccessibilityIssuesResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, PageAccessibilityIssuesCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="SiteimproveGetPageAccessibilityIssuesResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveGetPageAccessibilityIssuesResponse"/>.</returns>
        public static SiteimproveGetPageAccessibilityIssuesResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new SiteimproveGetPageAccessibilityIssuesResponse(response);

        }

        #endregion

    }

}