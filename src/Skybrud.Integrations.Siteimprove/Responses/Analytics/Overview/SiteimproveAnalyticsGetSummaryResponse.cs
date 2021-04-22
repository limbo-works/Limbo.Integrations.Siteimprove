﻿using System;
using Skybrud.Essentials.Http;
using Skybrud.Integrations.Siteimprove.Models.Analytics.Overview;

namespace Skybrud.Integrations.Siteimprove.Responses.Analytics.Overview {

    public class SiteimproveAnalyticsGetSummaryResponse : SiteimproveResponse<SiteimproveAnalyticsSite> {

        #region Constructors

        private SiteimproveAnalyticsGetSummaryResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SiteimproveAnalyticsSite.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SiteimproveAnalyticsGetSummaryResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsGetSummaryResponse"/>.</returns>
        public static SiteimproveAnalyticsGetSummaryResponse ParseResponse(IHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new SiteimproveAnalyticsGetSummaryResponse(response);

        }

        #endregion

    }

}