using System;
using System.Net;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Exceptions {

    public class SiteimproveApiException : Exception {

        public IHttpResponse Response { get; }

        public HttpStatusCode StatusCode { get; }

        public string Type { get; }

        public SiteimproveApiException(IHttpResponse response, string message, string type) : base(message) {
            Response = response;
            StatusCode = response.StatusCode;
            Type = type;
        }

    }

}