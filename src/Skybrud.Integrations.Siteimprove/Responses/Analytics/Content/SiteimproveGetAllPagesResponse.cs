using System;
using Skybrud.Essentials.Http;
using Skybrud.Integrations.Siteimprove.Models.Analytics.Content;

namespace Skybrud.Integrations.Siteimprove.Responses.Analytics.Content {

    public class SiteimproveGetAllPagesResponse : SiteimproveResponse<SiteimproveAnalyticsContentPageList> {

        #region Constructors

        private SiteimproveGetAllPagesResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SiteimproveAnalyticsContentPageList.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SiteimproveGetAllPagesResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveGetAllPagesResponse"/>.</returns>
        public static SiteimproveGetAllPagesResponse ParseResponse(IHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new SiteimproveGetAllPagesResponse(response);

        }

        #endregion

    }
}