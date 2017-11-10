﻿using Skybrud.Essentials.Common;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces;

namespace Skybrud.Siteimprove.Options.Accessibility {
    
    /// <see>
    ///     <cref>https://api.siteimprove.com/v2/documentation#!/Accessibility/get_sites_site_id_accessibility_overview_summary</cref>
    /// </see>
    public class SiteimproveGetAccessibilitySummaryOptions : IGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the ID of the site.
        /// </summary>
        public long SiteId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the group.
        /// </summary>
        public long GroupId { get; set; }

        /// <summary>
        /// Gets or sets the page number to show when more than one page in paged output.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the number of items/records per page in paged output.
        /// </summary>
        public int PageSize { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public SiteimproveGetAccessibilitySummaryOptions() { }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        public SiteimproveGetAccessibilitySummaryOptions(long siteId) {
            SiteId = siteId;
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="siteId"/>, <paramref name="page"/> and <paramref name="pageSize"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page that should be returned.</param>
        /// <param name="pageSize">The maximum amount of items per page.</param>
        public SiteimproveGetAccessibilitySummaryOptions(long siteId, int page, int pageSize) {
            SiteId = siteId;
            Page = page;
            PageSize = pageSize;
        }

        #endregion

        #region Member methods

        public SocialQueryString GetQueryString() {
            if (SiteId == 0) throw new PropertyNotSetException("SiteId");
            SocialQueryString query = new SocialQueryString();
            query.Add("site_id", SiteId);
            if (GroupId > 0) query.Add("group_id", GroupId);
            if (Page > 0) query.Add("page", Page);
            if (PageSize > 0) query.Add("page_size", PageSize);
            return query;
        }

        #endregion

    }

}