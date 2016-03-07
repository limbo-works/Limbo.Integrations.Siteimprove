using System;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces;

namespace Skybrud.Siteimprove.Options.Pages {
    
    public class SiteimproveGetPagesOptions : IGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the ID of the site.
        /// </summary>
        public int SiteId { get; set; }

        /// <summary>
        /// Gets or sets the page to retrive. If set to <code>0</code> (default), the parameter will not be send to the
        /// Siteimprove API.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the number of items that should be returned for each page. If set to <code>0</code> (default),
        /// the parameter will not be send to the Siteimprove API.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the URL pattern. If specified, only pages with a URL that matches the pattern will be
        /// returned. If not specified, all pages will be returned.
        /// </summary>
        public string Url { get; set; }

        #endregion

        #region Member methods

        public SocialQueryString GetQueryString() {
            SocialQueryString query = new SocialQueryString();
            if (Page > 0) query.Add("page", Page);
            if (PageSize > 0) query.Add("page_size", PageSize);
            if (!String.IsNullOrEmpty(Url)) query.Add("url", Url);
            return query;
        }

        #endregion

    }

}