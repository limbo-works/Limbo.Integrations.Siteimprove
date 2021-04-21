using System;
using System.Net;
using Skybrud.Essentials.Http;

namespace Skybrud.Integrations.Siteimprove.Exceptions {

    public class SiteimproveHttpException : Exception {

        public IHttpResponse Response { get; }

        public HttpStatusCode StatusCode { get; }

        public SiteimproveHttpException(IHttpResponse response) : base($"Invalid response received from the Siteimprove API (Status: {(int) response.StatusCode})") {
            Response = response;
            StatusCode = response.StatusCode;
        }

    }

}