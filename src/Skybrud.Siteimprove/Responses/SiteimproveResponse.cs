using System;
using System.Net;
using Skybrud.Siteimprove.Exceptions;
using Skybrud.Siteimprove.Objects;
using Skybrud.Social.Http;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Responses {

    public class SiteimproveResponse {

        /// <summary>
        /// Gets a reference to the underlying response.
        /// </summary>
        public SocialHttpResponse Response { get; private set; }

        /// <summary>
        /// The Siteimprove API enforces rate limiting. See the API documentation for further information.
        /// </summary>
        /// <see cref="http://developer.siteimprove.com/v1/api-guidelines/" />
        public SiteimproveRateLimiting RateLimiting { get; private set; }

        protected SiteimproveResponse(SocialHttpResponse response) {
            Response = response;
            RateLimiting = new SiteimproveRateLimiting {
                Limit = Int32.Parse(response.Headers["X-Rate-Limit"]),
                Remaining = Int32.Parse(response.Headers["X-Rate-Remaining"]),
                Reset = Int32.Parse(response.Headers["X-Rate-Reset"].Split(' ')[0])
            };
        }

    }

    public class SiteimproveResponse<T> : SiteimproveResponse {

        public T Data { get; private set; }

        protected SiteimproveResponse(SocialHttpResponse response) : base(response) { }

        #region Static methods

        public static SiteimproveResponse<T> ParseResponse(SocialHttpResponse response, Func<JsonObject, T> func) {

            if (response == null) return null;

            // Parse the raw JSON response
            JsonObject obj = response.GetBodyAsJsonObject();
            if (obj == null) return null;

            // Validate the response
            if (response.StatusCode != HttpStatusCode.OK) {
                throw new SiteimproveApiException(response, obj.GetString("message"), obj.GetString("type"));
            }

            // Initialize the response object
            return new SiteimproveResponse<T>(response) {
                Data = func(obj)
            };

        }

        #endregion

    }

}
