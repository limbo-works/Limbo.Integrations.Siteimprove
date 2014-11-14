namespace Skybrud.Siteimprove.Objects {
    
    public class SiteimproveRateLimiting {

        public int Limit { get; internal set; }

        public int Remaining { get; internal set; }

        public int Reset { get; internal set; }

    }

}