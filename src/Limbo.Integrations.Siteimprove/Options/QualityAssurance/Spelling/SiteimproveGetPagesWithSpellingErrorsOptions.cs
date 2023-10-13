using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;

namespace Limbo.Integrations.Siteimprove.Options.QualityAssurance.Spelling {

    /// <summary>
    /// Options for getting pages with misspellings and/or potential misspellings.
    /// </summary>
    /// <see>
    ///     <cref>https://api.siteimprove.com/v2/documentation#!/Quality_Assurance/get_sites_site_id_quality_assurance_spelling_pages</cref>
    /// </see>
    public class SiteimproveGetPagesWithSpellingErrorsOptions : IHttpRequestOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the ID of the site.
        /// </summary>
        public long SiteId { get; set; }

        /// <summary>
        /// Gets the sets the ID for specific group.
        /// </summary>
        public int GroupId { get; set; }

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
        public SiteimproveGetPagesWithSpellingErrorsOptions() { }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        public SiteimproveGetPagesWithSpellingErrorsOptions(long siteId) {
            SiteId = siteId;
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="siteId"/>, <paramref name="page"/> and <paramref name="pageSize"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page that should be returned.</param>
        /// <param name="pageSize">The maximum amount of items per page.</param>
        public SiteimproveGetPagesWithSpellingErrorsOptions(long siteId, int page, int pageSize) {
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
            if (GroupId > 0) query.Add("group_id", GroupId);
            if (Page > 0) query.Add("page", Page);
            if (PageSize > 0) query.Add("page_size", PageSize);

            // Initialize a new request
            return HttpRequest.Get($"/v2/sites/{SiteId}/quality_assurance/spelling/pages", query);

        }

        #endregion

    }

}