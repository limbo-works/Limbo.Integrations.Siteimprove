using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;

namespace Limbo.Integrations.Siteimprove.Options.Accessibility {
    
    public class SiteimproveGetAccessibilityGroupsOptions : IHttpRequestOptions {

        #region Properties

        public long SiteId { get; set; }

        public int Page { get; set; }

        public int PageSize { get; set; }

        public string Query { get; set; }

        #endregion

        #region Constructors

        public SiteimproveGetAccessibilityGroupsOptions() { }

        public SiteimproveGetAccessibilityGroupsOptions(long siteId) {
            SiteId = siteId;
        }

        public SiteimproveGetAccessibilityGroupsOptions(long siteId, int page, int pageSize) {
            SiteId = siteId;
            Page = page;
            PageSize = pageSize;
        }

        #endregion

        #region Member methods

        public IHttpRequest GetRequest() {

            if (SiteId == 0) throw new PropertyNotSetException(nameof(SiteId));

            // Construct the query string
            IHttpQueryString query = new HttpQueryString();
            if (Page > 0) query.Add("page", Page);
            if (PageSize > 0) query.Add("page_size", PageSize);

            // Initialize a new request
            return HttpRequest.Get($"/v2/sites/{SiteId}/accessibility/overview/groups", query);

        }

        #endregion

    }

}