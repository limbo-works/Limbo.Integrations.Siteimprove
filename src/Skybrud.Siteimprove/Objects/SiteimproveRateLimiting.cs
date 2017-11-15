using System;
using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Objects {
    
    public class SiteimproveRateLimiting {

        public int Limit { get; internal set; }

        public int Remaining { get; internal set; }

        public int Reset { get; internal set; }

        public SiteimproveRateLimiting(SocialHttpResponse response) {

            int limit;
            int remaining;
            int reset;

            Int32.TryParse(response.Headers["X-Rate-Limit"], out limit);
            Int32.TryParse(response.Headers["X-Rate-Remaining"], out remaining);
            Int32.TryParse(response.Headers["X-Rate-Reset"], out reset);

            Limit = limit;
            Remaining = remaining;
            Reset = reset;

        }

    }

}