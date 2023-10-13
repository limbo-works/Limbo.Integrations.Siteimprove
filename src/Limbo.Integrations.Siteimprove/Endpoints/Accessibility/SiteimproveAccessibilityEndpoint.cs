using Limbo.Integrations.Siteimprove.Options.Accessibility;
using Limbo.Integrations.Siteimprove.Options.Accessibility.Pages;
using Limbo.Integrations.Siteimprove.Responses.Accessibility;
using Limbo.Integrations.Siteimprove.Responses.Accessibility.Pages;

namespace Limbo.Integrations.Siteimprove.Endpoints.Accessibility {

    public class SiteimproveAccessibilityEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveAccessibilityRawEndpoint Raw => Service.Client.Accessibility;

        #endregion

        #region Constructors

        internal SiteimproveAccessibilityEndpoint(SiteimproveService service) {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a overview for accessibility for the site with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>An instance of <see cref="SiteimproveAccessibilitySummaryListResponse"/> representing the response.</returns>
        public SiteimproveAccessibilitySummaryListResponse GetSummary(long siteId) {
            return new SiteimproveAccessibilitySummaryListResponse(Raw.GetSummary(siteId));
        }

        /// <summary>
        /// Gets a summary about the accessibility for the site matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SiteimproveAccessibilitySummaryListResponse"/> representing the response.</returns>
        public SiteimproveAccessibilitySummaryListResponse GetSummary(SiteimproveGetAccessibilitySummaryOptions options) {
            return new SiteimproveAccessibilitySummaryListResponse(Raw.GetSummary(options));
        }

        /// <summary>
        /// Gets an overview of groups for accessibility for the site with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>An instance of <see cref="SiteimproveAccessibilityGroupListResponse"/> representing the response.</returns>
        public SiteimproveAccessibilityGroupListResponse GetGroups(long siteId) {
            return new SiteimproveAccessibilityGroupListResponse(Raw.GetGroups(siteId));
        }

        /// <summary>
        /// Gets an overview of groups for accessibility for the site with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page number to show when more than one page in paged output.</param>
        /// <param name="pageId">The number of items/records per page in paged output.</param>
        /// <returns>An instance of <see cref="SiteimproveAccessibilityGroupListResponse"/> representing the response.</returns>
        public SiteimproveAccessibilityGroupListResponse GetGroups(long siteId, int page, int pageId) {
            return new SiteimproveAccessibilityGroupListResponse(Raw.GetGroups(siteId, page, pageId));
        }

        /// <summary>
        /// Gets an overview of groups for accessibility for the site matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SiteimproveAccessibilityGroupListResponse"/> representing the response.</returns>
        public SiteimproveAccessibilityGroupListResponse GetGroups(SiteimproveGetAccessibilityGroupsOptions options) {
            return new SiteimproveAccessibilityGroupListResponse(Raw.GetGroups(options));
        }

        /// <summary>
        /// Gets the number of issues within a conformance level * severity set.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <returns>An instance of <see cref="SiteimproveAccessibilityPageIssuesListResponse"/> representing the response.</returns>
        public SiteimproveAccessibilityPageIssuesListResponse GetPageIssues(long siteId, long pageId) {
            return new SiteimproveAccessibilityPageIssuesListResponse(Raw.GetPageIssues(siteId, pageId));
        }

        /// <summary>
        /// Gets the number of issues within a conformance level * severity set.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <param name="page">The page number to show when more than one page in paged output.</param>
        /// <param name="pageSize">The number of items/records per page in paged output.</param>
        /// <returns>An instance of <see cref="SiteimproveAccessibilityPageIssuesListResponse"/> representing the response.</returns>
        public SiteimproveAccessibilityPageIssuesListResponse GetPageIssues(long siteId, long pageId, int page, int pageSize) {
            return new SiteimproveAccessibilityPageIssuesListResponse(Raw.GetPageIssues(siteId, pageId, page, pageSize));
        }

        /// <summary>
        /// Gets the number of issues within a conformance level * severity set.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SiteimproveAccessibilityPageIssuesListResponse"/> representing the response.</returns>
        public SiteimproveAccessibilityPageIssuesListResponse GetPageIssues(SiteimproveGetPageAccessibilityIssuesOptions options) {
            return new SiteimproveAccessibilityPageIssuesListResponse(Raw.GetPageIssues(options));
        }

        #endregion

    }

}