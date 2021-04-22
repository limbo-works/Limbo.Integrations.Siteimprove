using Skybrud.Essentials.Http;

namespace Skybrud.Integrations.Siteimprove.Models {
    
    public class SiteimproveRateLimiting {

        public int Limit { get; }

        public int Remaining { get; }

        public int Reset { get; }

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