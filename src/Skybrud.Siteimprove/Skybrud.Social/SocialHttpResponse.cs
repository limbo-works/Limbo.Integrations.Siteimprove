using System;
using System.IO;
using System.Net;

namespace Skybrud.Siteimprove.Skybrud.Social {
    
    public class SocialHttpResponse {

        public HttpWebResponse Response { get; private set; }
        public WebException Exception { get; private set; }

        public HttpStatusCode StatusCode { get; private set; }

        public string Body { get; private set; }
        
        internal SocialHttpResponse(HttpWebResponse response) {
            
            Response = response;

            StatusCode = response.StatusCode;

            using (Stream stream = Response.GetResponseStream()) {
                using (StreamReader reader = new StreamReader(stream)) {
                    Body = reader.ReadToEnd();
                }
            }
        
        }

        internal SocialHttpResponse(HttpWebResponse response, WebException exception) {
            
            Response = response;
            Exception = exception;

            StatusCode = response.StatusCode;

            using (Stream stream = Response.GetResponseStream()) {
                using (StreamReader reader = new StreamReader(stream)) {
                    Body = reader.ReadToEnd();
                }
            }

        }

        [Obsolete("Use property 'Body' instead.")]
        public string GetBodyAsString() {
            return Body;
        }

    }

}