using System;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces;

namespace Skybrud.Siteimprove.Options.Accessibility.Pages {
    
    public class SiteimproveGetPageAccessibilityIssuesOptions : IGetOptions {

        #region Properties

        public long SiteId { get; set; }

        public long PageId { get; set; }

        public int Page { get; set; }

        public int PageSize { get; set; }

        public string Query { get; set; }

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

        public SocialQueryString GetQueryString() {
            SocialQueryString query = new SocialQueryString();
            if (Page > 0) query.Add("page", Page);
            if (PageSize > 0) query.Add("page_size", PageSize);
            if (!String.IsNullOrWhiteSpace(Query)) query.Add("query", Query);
            return query;
        }

        #endregion

    }

}