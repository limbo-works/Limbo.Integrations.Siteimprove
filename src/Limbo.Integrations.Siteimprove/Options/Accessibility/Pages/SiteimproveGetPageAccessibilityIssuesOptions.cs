using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;

namespace Limbo.Integrations.Siteimprove.Options.Accessibility.Pages {

    public class SiteimproveGetPageAccessibilityIssuesOptions : IHttpRequestOptions {

        #region Properties

        public long SiteId { get; set; }

        public long PageId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        public string? Query { get; set; }

        #endregion

        #region Constructors

        public SiteimproveGetPageAccessibilityIssuesOptions() { }

        public SiteimproveGetPageAccessibilityIssuesOptions(long siteId, long pageId) {
            SiteId = siteId;
            PageId = pageId;
        }

        public SiteimproveGetPageAccessibilityIssuesOptions(long siteId, long pageId, int page, int pageSize) {
            SiteId = siteId;
            PageId = pageId;
            Page = page;
            PageSize = pageSize;
        }

        #endregion

        #region Member methods

        public IHttpRequest GetRequest() {

            if (SiteId == 0) throw new PropertyNotSetException(nameof(SiteId));
            if (PageId == 0) throw new PropertyNotSetException(nameof(PageId));

            // Construct the query string
            IHttpQueryString query = new HttpQueryString();
            if (Page > 0) query.Add("page", Page);
            if (PageSize > 0) query.Add("page_size", PageSize);
            if (!string.IsNullOrWhiteSpace(Query)) query.Add("query", Query!);

            // Initialize a new request
            return HttpRequest.Get($"/v2/sites/{SiteId}/accessibility/pages/{PageId}/issues", query);

        }

        #endregion

    }

}