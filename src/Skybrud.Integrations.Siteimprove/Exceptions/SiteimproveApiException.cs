using System;
using System.Net;
using Skybrud.Social.Http;

namespace Skybrud.Integrations.Siteimprove.Exceptions {

    public class SiteimproveApiException : Exception {

        public SocialHttpResponse Response { get; private set; }

        public HttpStatusCode StatusCode { get; private set; }

        public string Type { get; private set; }

        public SiteimproveApiException(SocialHttpResponse response, string message, string type) : base(message) {
            Response = response;
            StatusCode = response.StatusCode;
            Type = type;
        }

    }

}
