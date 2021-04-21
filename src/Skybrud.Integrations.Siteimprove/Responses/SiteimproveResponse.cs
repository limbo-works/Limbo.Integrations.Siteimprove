using System;
using System.Net;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Json;
using Skybrud.Integrations.Siteimprove.Exceptions;
using Skybrud.Integrations.Siteimprove.Models;

namespace Skybrud.Integrations.Siteimprove.Responses {

    /// <summary>
    /// Class representing a response from the Siteimprove API.
    /// </summary>
    public class SiteimproveResponse : HttpResponseBase {

        #region Properties

        /// <summary>
        /// The Siteimprove API enforces rate limiting. See the API documentation for further information.
        /// </summary>
        /// <see cref="http://developer.siteimprove.com/v1/api-guidelines/" />
        public SiteimproveRateLimiting RateLimiting { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        protected SiteimproveResponse(IHttpResponse response) : base(response) {
            RateLimiting = new SiteimproveRateLimiting(response);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Validates the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The response to be validated.</param>
        public static void ValidateResponse(IHttpResponse response) {

            // Skip error checking if the server responds with an OK status code
            if (response.StatusCode == HttpStatusCode.OK) return;
            
            throw new SiteimproveHttpException(response);

        }

        #endregion

    }

    /// <summary>
    /// Class representing a response from the Siteimprove API.
    /// </summary>
    public class SiteimproveResponse<T> : SiteimproveResponse {

        #region Properties

        /// <summary>
        /// Gets the body of the response.
        /// </summary>
        public T Body { get; protected set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        protected SiteimproveResponse(IHttpResponse response) : base(response) { }

        #endregion

    }

}
