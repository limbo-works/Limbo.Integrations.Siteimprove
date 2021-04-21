using Skybrud.Essentials.Http;

namespace Skybrud.Integrations.Siteimprove.Models {
    
    public class SiteimproveRateLimiting {

        public int Limit { get; internal set; }

        public int Remaining { get; internal set; }

        public int Reset { get; internal set; }

        public SiteimproveRateLimiting(IHttpResponse response) {

            int.TryParse(response.Headers["X-Rate-Limit"], out int limit);
            int.TryParse(response.Headers["X-Rate-Remaining"], out int remaining);
            int.TryParse(response.Headers["X-Rate-Reset"], out int reset);

            Limit = limit;
            Remaining = remaining;
            Reset = reset;

        }

    }

}