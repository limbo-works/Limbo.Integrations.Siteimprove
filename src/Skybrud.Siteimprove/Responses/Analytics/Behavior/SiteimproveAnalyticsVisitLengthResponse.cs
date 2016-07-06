using System;
using Skybrud.Siteimprove.Objects.Analytics.Behavior;
using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Responses.Analytics.Behavior {

    public class SiteimproveAnalyticsVisitLengthResponse : SiteimproveResponse<SiteimproveAnalyticsVisitLengthGraphList> {

        #region Constructors

        private SiteimproveAnalyticsVisitLengthResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SiteimproveAnalyticsVisitLengthGraphList.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SiteimproveAnalyticsVisitLengthResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsVisitLengthResponse"/>.</returns>
        public static SiteimproveAnalyticsVisitLengthResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new SiteimproveAnalyticsVisitLengthResponse(response);

        }

        #endregion

    }

}