using System;
using System.Net;
using Skybrud.Social.Http;

namespace Skybrud.Integrations.Siteimprove.Exceptions {

    public class SiteimproveHttpException : Exception {

        public SocialHttpResponse Response { get; private set; }

        public HttpStatusCode StatusCode { get; private set; }

        public string Type { get; private set; }

        public SiteimproveHttpException(SocialHttpResponse response) : base("Invalid response received from the Siteimprove API (Status: " + ((int) response.StatusCode) + ")") {
            Response = response;
            StatusCode = response.StatusCode;
        }

    }

}
