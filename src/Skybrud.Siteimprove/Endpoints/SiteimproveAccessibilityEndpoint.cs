using Skybrud.Siteimprove.Endpoints.Raw;
using Skybrud.Siteimprove.Options.Accessibility;
using Skybrud.Siteimprove.Responses.Accessibility;

namespace Skybrud.Siteimprove.Endpoints {

    public class SiteimproveAccessibilityEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; private set; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveAccessibilityRawEndpoint Raw {
            get { return Service.Client.Accessibility; }
        }

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
        /// <returns>An instance of <see cref="SiteimproveGetAccessibilitySummaryResponse"/> representing the response.</returns>
        public SiteimproveGetAccessibilitySummaryResponse GetSummary(long siteId) {
            return SiteimproveGetAccessibilitySummaryResponse.ParseResponse(Raw.GetSummary(siteId));
        }

        /// <summary>
        /// Gets a summary about the accessibility for the site matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SiteimproveGetAccessibilitySummaryResponse"/> representing the response.</returns>
        public SiteimproveGetAccessibilitySummaryResponse GetSummary(SiteimproveGetAccessibilitySummaryOptions options) {
            return SiteimproveGetAccessibilitySummaryResponse.ParseResponse(Raw.GetSummary(options));
        }

        /// <summary>
        /// Gets an overview of groups for accessibility for the site with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>An instance of <see cref="SiteimproveGetAccessibilityGroupsResponse"/> representing the response.</returns>
        public SiteimproveGetAccessibilityGroupsResponse GetGroups(long siteId) {
            return SiteimproveGetAccessibilityGroupsResponse.ParseResponse(Raw.GetGroups(siteId));
        }

        /// <summary>
        /// Gets an overview of groups for accessibility for the site with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page number to show when more than one page in paged output.</param>
        /// <param name="pageId">The number of items/records per page in paged output.</param>
        /// <returns>An instance of <see cref="SiteimproveGetAccessibilityGroupsResponse"/> representing the response.</returns>
        public SiteimproveGetAccessibilityGroupsResponse GetGroups(long siteId, int page, int pageId) {
            return SiteimproveGetAccessibilityGroupsResponse.ParseResponse(Raw.GetGroups(siteId, page, pageId));
        }

        /// <summary>
        /// Gets an overview of groups for accessibility for the site matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SiteimproveGetAccessibilityGroupsResponse"/> representing the response.</returns>
        public SiteimproveGetAccessibilityGroupsResponse GetGroups(SiteimproveGetAccessibilityGroupsOptions options) {
            return SiteimproveGetAccessibilityGroupsResponse.ParseResponse(Raw.GetGroups(options));
        }

        #endregion

    }

}