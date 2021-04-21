using System;
using Skybrud.Integrations.Siteimprove.Endpoints.Raw;
using Skybrud.Integrations.Siteimprove.Objects.QualityAssurance.BrokenLinks.Overview;
using Skybrud.Integrations.Siteimprove.Responses;
using Skybrud.Integrations.Siteimprove.Responses.QualityAssurance.BrokenLinks;
using Skybrud.Social.Http;

namespace Skybrud.Integrations.Siteimprove.Endpoints {

    public class SiteimproveBrokenLinksEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveBrokenLinksRawEndpoint Raw => Service.Client.QualityAssurance.BrokenLinks;

        #endregion

        #region Constructors

        internal SiteimproveBrokenLinksEndpoint(SiteimproveService service) {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a overview for broken links.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        public SiteimproveResponse<BrokenLinksCollection> GetOverview(int siteId) {
            return GetOverview(siteId, 0, 0);
        }

        /// <summary>
        /// Gets a overview for broken links.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageSize">The maximum amount of items that should be returned on each page.</param>
        public SiteimproveResponse<BrokenLinksCollection> GetOverview(int siteId, int pageSize) {
            return GetOverview(siteId, 0, pageSize);
        }

        /// <summary>
        /// Gets a overview for broken links.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page that should be returned.</param>
        /// <param name="pageSize">The maximum amount of items that should be returned on each page.</param>
        public SiteimproveResponse<BrokenLinksCollection> GetOverview(int siteId, int page, int pageSize) {
            return SiteimproveGetBrokenLinksResponse.ParseResponse(Raw.GetOverview(siteId, page, pageSize));
        }

        /// <summary>
        /// Gets a list of pages with broken links.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        public SocialHttpResponse GetPages(int siteId) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a list of broken links on the site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        public SocialHttpResponse GetLinks(int siteId) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a list of pages for a broken link.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="linkId">The ID of the link.</param>
        public SocialHttpResponse GetPagesFromLink(int siteId, int linkId) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Geta a list of broken links on a page.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageId">The ID of the page.</param>
        public SocialHttpResponse GetLinksFromPage(int siteId, int pageId) {
            throw new NotImplementedException();
        }

        #endregion

    }

}