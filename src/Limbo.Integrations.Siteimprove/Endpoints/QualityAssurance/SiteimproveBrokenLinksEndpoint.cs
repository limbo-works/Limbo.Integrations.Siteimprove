﻿using System;
using Limbo.Integrations.Siteimprove.Models.QualityAssurance.BrokenLinks.Overview;
using Limbo.Integrations.Siteimprove.Options.QualityAssurance.BrokenLinks;
using Limbo.Integrations.Siteimprove.Responses;
using Limbo.Integrations.Siteimprove.Responses.QualityAssurance.BrokenLinks;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Endpoints.QualityAssurance;

public class SiteimproveBrokenLinksEndpoint {

    #region Properties

    /// <summary>
    /// A reference to the Siteimprove service.
    /// </summary>
    public SiteimproveHttpService Service { get; }

    /// <summary>
    /// A reference to the raw endpoint.
    /// </summary>
    public SiteimproveBrokenLinksRawEndpoint Raw => Service.Client.QualityAssurance.BrokenLinks;

    #endregion

    #region Constructors

    internal SiteimproveBrokenLinksEndpoint(SiteimproveHttpService service) {
        Service = service;
    }

    #endregion

    #region Methods

    /// <summary>
    /// Gets a overview for broken links.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
    public SiteimproveResponse<SiteimproveBrokenLinksResultList> GetOverview(long siteId) {
        return new SiteimproveBrokenLinksResponse(Raw.GetOverview(siteId));
    }

    /// <summary>
    /// Gets a overview for broken links.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
    /// <param name="pageSize">The maximum amount of items that should be returned on each page.</param>
    public SiteimproveResponse<SiteimproveBrokenLinksResultList> GetOverview(long siteId, int pageSize) {
        return new SiteimproveBrokenLinksResponse(Raw.GetOverview(siteId, pageSize));
    }

    /// <summary>
    /// Gets a overview for broken links.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
    /// <param name="page">The page that should be returned.</param>
    /// <param name="pageSize">The maximum amount of items that should be returned on each page.</param>
    public SiteimproveResponse<SiteimproveBrokenLinksResultList> GetOverview(long siteId, int page, int pageSize) {
        return new SiteimproveBrokenLinksResponse(Raw.GetOverview(siteId, page, pageSize));
    }

    /// <summary>
    /// Gets a list of pages with broken links.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
    /// <returns>Returns an instance of <see cref="SiteimprovePageWithBrokenLinksListResponse"/> representing the response.</returns>
    /// <see>
    ///     <cref>https://api.siteimprove.com/v2/documentation#!/Quality_Assurance/get_sites_site_id_quality_assurance_links_pages_with_broken_links</cref>
    /// </see>
    public SiteimprovePageWithBrokenLinksListResponse GetPagesWithBrokenLinks(long siteId) {
        return new SiteimprovePageWithBrokenLinksListResponse(Raw.GetPagesWithBrokenLinks(siteId));
    }

    /// <summary>
    /// Gets a list of pages with broken links.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
    /// <param name="page">The page that should be returned.</param>
    /// <param name="pageSize">The maximum amount of items per page.</param>
    /// <returns>Returns an instance of <see cref="SiteimprovePageWithBrokenLinksListResponse"/> representing the response.</returns>
    /// <see>
    ///     <cref>https://api.siteimprove.com/v2/documentation#!/Quality_Assurance/get_sites_site_id_quality_assurance_links_pages_with_broken_links</cref>
    /// </see>
    public SiteimprovePageWithBrokenLinksListResponse GetPagesWithBrokenLinks(long siteId, int page, int pageSize) {
        return new SiteimprovePageWithBrokenLinksListResponse(Raw.GetPagesWithBrokenLinks(siteId, page, pageSize));
    }

    /// <summary>
    /// Gets a list of pages with broken links.
    /// </summary>
    /// <param name="options">The options for the call to the API.</param>
    /// <returns>Returns an instance of <see cref="SiteimprovePageWithBrokenLinksListResponse"/> representing the response.</returns>
    /// <see>
    ///     <cref>https://api.siteimprove.com/v2/documentation#!/Quality_Assurance/get_sites_site_id_quality_assurance_links_pages_with_broken_links</cref>
    /// </see>
    public SiteimprovePageWithBrokenLinksListResponse GetPagesWithBrokenLinks(SiteimproveGetPagesWithBrokenLinksOptions options) {
        return new SiteimprovePageWithBrokenLinksListResponse(Raw.GetPagesWithBrokenLinks(options));
    }

    /// <summary>
    /// Gets a list of broken links on the site with the specified <code>siteId</code>.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
    public IHttpResponse GetLinks(long siteId) {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Gets a list of pages for a broken link.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
    /// <param name="linkId">The ID of the link.</param>
    public IHttpResponse GetPagesFromLink(long siteId, int linkId) {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Geta a list of broken links on a page.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
    /// <param name="pageId">The ID of the page.</param>
    public IHttpResponse GetLinksFromPage(long siteId, int pageId) {
        throw new NotImplementedException();
    }

    #endregion

}