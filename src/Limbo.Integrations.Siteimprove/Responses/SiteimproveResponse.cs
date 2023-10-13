using System.Net;
using Limbo.Integrations.Siteimprove.Exceptions;
using Limbo.Integrations.Siteimprove.Models;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Responses {

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
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        protected SiteimproveResponse(IHttpResponse response) : base(response) {

            // Throw an exception if the statuis code is not 200 OK
            if (response.StatusCode != HttpStatusCode.OK) throw new SiteimproveHttpException(response);

            RateLimiting = new SiteimproveRateLimiting(response);

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
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        protected SiteimproveResponse(IHttpResponse response) : base(response) { }

        #endregion

    }

}