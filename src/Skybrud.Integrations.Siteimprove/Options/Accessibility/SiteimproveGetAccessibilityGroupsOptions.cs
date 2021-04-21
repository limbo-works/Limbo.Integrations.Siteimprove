using System;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces;

namespace Skybrud.Integrations.Siteimprove.Options.Accessibility {
    
    public class SiteimproveGetAccessibilityGroupsOptions : IGetOptions {

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