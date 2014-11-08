using System;
using System.Net;
using Skybrud.Social;

namespace Skybrud.Siteimprove.Beta2.Responses {

    public class SiteimproveException : Exception {

        public HttpStatusCode StatusCode { get; private set; }

        public SiteimproveException(HttpStatusCode statusCode) {
            StatusCode = statusCode;
        }

    }

    //public class SiteimproveApiException : SiteimproveException {

    //    public SiteimproveApiException(HttpStatusCode statusCode) : base(statusCode) {
    //        StatusCode = statusCode;
    //    }

    //}

    public class SiteimproveResponse {

        protected SiteimproveResponse() {
            
            // Make default constructor protected

        }

        /// <summary>
        /// Validates the specified instance of <code>SocialHttpResponse</code>. If the status is anything else than <code>OK</code>, an exception will be thrown.
        /// </summary>
        /// <param name="response"></param>
        public static void Validate(SocialHttpResponse response) {
            if (response.StatusCode == HttpStatusCode.OK) return;
            throw new SiteimproveException(response.StatusCode);
        }

    }

}
