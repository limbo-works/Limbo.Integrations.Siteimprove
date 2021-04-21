using System;
using Skybrud.Integrations.Siteimprove.Objects.Analytics.Visitors;
using Skybrud.Social.Http;

namespace Skybrud.Integrations.Siteimprove.Responses.Analytics.Visitors {

    public class SiteimproveGetDevicesResponse : SiteimproveResponse<SiteimproveAnalyticsDevicesList> {

        #region Constructors

        private SiteimproveGetDevicesResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SiteimproveAnalyticsDevicesList.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SiteimproveGetDevicesResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveGetDevicesResponse"/>.</returns>
        public static SiteimproveGetDevicesResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new SiteimproveGetDevicesResponse(response);

        }

        #endregion

    }

}