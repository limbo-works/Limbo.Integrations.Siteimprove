using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http;

namespace Skybrud.Integrations.Siteimprove.Options.Analytics.Content {

    public class SiteimproveGetMostPopularPagesOptions : SiteimproveAnalyticsGetPeriodOptionsNope {

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public SiteimproveGetMostPopularPagesOptions() { }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        public SiteimproveGetMostPopularPagesOptions(long siteId) {
            SiteId = siteId;
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="siteId"/>, <paramref name="page"/> and <paramref name="pageSize"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page that should be returned.</param>
        /// <param name="pageSize">The maximum amount of items per page.</param>
        public SiteimproveGetMostPopularPagesOptions(long siteId, int page, int pageSize) {
            SiteId = siteId;
            Page = page;
            PageSize = pageSize;
        }

        #endregion

        #region Member methods

        public override IHttpRequest GetRequest() {

            if (SiteId == 0) throw new PropertyNotSetException(nameof(SiteId));

            // Initialize a new request
            return HttpRequest.Get($"/v2/sites/{SiteId}/analytics/content/most_popular_pages", GetQueryString());

        }

        #endregion

    }

}