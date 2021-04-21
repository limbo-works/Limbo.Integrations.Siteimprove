using System;
using Skybrud.Integrations.Siteimprove.Models.QualityAssurance.Spelling.Overview;
using Skybrud.Social.Http;

namespace Skybrud.Integrations.Siteimprove.Responses.QualityAssurance.Spelling {
    
    public class SiteimproveGetSpellingResponse : SiteimproveResponse<SpellingCollection> {

        #region Constructors

        private SiteimproveGetSpellingResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SpellingCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="SiteimproveGetSpellingResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="SiteimproveGetSpellingResponse"/>.</returns>
        public static SiteimproveGetSpellingResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new SiteimproveGetSpellingResponse(response);

        }

        #endregion

    }

}