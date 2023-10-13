using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;

namespace Limbo.Integrations.Siteimprove.Options.Analytics.Content {

    /// <see>
    ///     <cref>https://api.siteimprove.com/v2/documentation#!/Analytics/get_sites_site_id_analytics_content_all_pages</cref>
    /// </see>
    public class SiteimproveAnalyticsGetAllPagesOptions : SiteimproveAnalyticsGetPeriodOptionsNope {

        #region Properties

        /// <summary>
        /// Gets or sets a text based query that all returned items should match.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Gets or sets the field that <see cref="Query"/> should match.
        /// </summary>
        public SiteimproveAnalyticsGetAllPagesField SearchIn { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public SiteimproveAnalyticsGetAllPagesOptions() { }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        public SiteimproveAnalyticsGetAllPagesOptions(long siteId) {
            SiteId = siteId;
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="siteId"/>, <paramref name="page"/> and <paramref name="pageSize"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page that should be returned.</param>
        /// <param name="pageSize">The maximum amount of items per page.</param>
        public SiteimproveAnalyticsGetAllPagesOptions(long siteId, int page, int pageSize) {
            SiteId = siteId;
            Page = page;
            PageSize = pageSize;
        }

        #endregion

        #region Member methods

        protected override IHttpQueryString GetQueryString() {

            IHttpQueryString query = base.GetQueryString();

            if (!string.IsNullOrWhiteSpace(Query)) {
                query.Add("query", Query);
                query.Add("search_in", SearchIn.ToString().ToLower());
            }

            return query;

        }

        public override IHttpRequest GetRequest() {

            if (SiteId == 0) throw new PropertyNotSetException(nameof(SiteId));

            // Initialize a new request
            return HttpRequest.Get($"/v2/sites/{SiteId}/analytics/content/all_pages", GetQueryString());

        }

        #endregion

    }

}