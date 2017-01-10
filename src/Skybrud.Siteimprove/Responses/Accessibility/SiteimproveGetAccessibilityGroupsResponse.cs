using System;
using Skybrud.Siteimprove.Objects.Accessibility.Groups;
using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Responses.Accessibility {

    public class SiteimproveGetAccessibilityGroupsResponse : SiteimproveResponse<AccessibilityGroupsList> {

        #region Constructors

        private SiteimproveGetAccessibilityGroupsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, AccessibilityGroupsList.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SiteimproveGetAccessibilityGroupsResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveGetAccessibilityGroupsResponse"/>.</returns>
        public static SiteimproveGetAccessibilityGroupsResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new SiteimproveGetAccessibilityGroupsResponse(response);

        }

        #endregion

    }

}