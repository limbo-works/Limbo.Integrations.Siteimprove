using System;
using Limbo.Integrations.Siteimprove.Http;
using Limbo.Integrations.Siteimprove.Options.Accessibility;
using Limbo.Integrations.Siteimprove.Options.Accessibility.Pages;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Endpoints.Accessibility {

    public class SiteimproveAccessibilityRawEndpoint {

        #region Properties

        public SiteimproveHttpClient Client { get; }

        #endregion

        #region Constructor

        internal SiteimproveAccessibilityRawEndpoint(SiteimproveHttpClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a summary about the accessibility for the site with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetSummary(long siteId) {
            return GetSummary(new SiteimproveGetAccessibilitySummaryOptions(siteId));
        }

        /// <summary>
        /// Gets a summary about the accessibility for the site matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetSummary(SiteimproveGetAccessibilitySummaryOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        /// <summary>
        /// Gets an overview of groups for accessibility for the site with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetGroups(long siteId) {
            return GetGroups(new SiteimproveGetAccessibilityGroupsOptions(siteId));
        }

        /// <summary>
        /// Gets an overview of groups for accessibility for the site with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page number to show when more than one page in paged output.</param>
        /// <param name="pageId">The number of items/records per page in paged output.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetGroups(long siteId, int page, int pageId) {
            return GetGroups(new SiteimproveGetAccessibilityGroupsOptions(siteId, page, pageId));
        }

        /// <summary>
        /// Gets an overview of groups for accessibility for the site matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetGroups(SiteimproveGetAccessibilityGroupsOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        /// <summary>
        /// Gets the number of issues within a conformance level * severity set.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetPageIssues(long siteId, long pageId) {
            return GetPageIssues(new SiteimproveGetPageAccessibilityIssuesOptions(siteId, pageId));
        }

        /// <summary>
        /// Gets the number of issues within a conformance level * severity set.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <param name="page">The page number to show when more than one page in paged output.</param>
        /// <param name="pageSize">The number of items/records per page in paged output.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetPageIssues(long siteId, long pageId, int page, int pageSize) {
            return GetPageIssues(new SiteimproveGetPageAccessibilityIssuesOptions(siteId, pageId, page, pageSize));
        }

        /// <summary>
        /// Gets the number of issues within a conformance level * severity set.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetPageIssues(SiteimproveGetPageAccessibilityIssuesOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        #endregion

    }

}