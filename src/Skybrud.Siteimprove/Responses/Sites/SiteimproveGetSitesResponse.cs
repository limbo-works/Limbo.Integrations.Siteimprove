﻿using System;
using Skybrud.Siteimprove.Objects.Sites;
using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Responses.Sites {
    
    public class SiteimproveGetSitesResponse : SiteimproveResponse<SiteimproveSitesCollection> {

        #region Constructors

        private SiteimproveGetSitesResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SiteimproveSitesCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SiteimproveGetSitesResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveGetSitesResponse"/>.</returns>
        public static SiteimproveGetSitesResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new SiteimproveGetSitesResponse(response);

        }

        #endregion

    }

}