using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;

namespace Limbo.Integrations.Siteimprove.Options.Content;

public class SiteimproveGetPagesOptions : IHttpRequestOptions {

    #region Properties

    /// <summary>
    /// Gets or sets the ID of the site.
    /// </summary>
    public long SiteId { get; set; }

    /// <summary>
    /// Gets or sets the page to retrive. If set to <code>0</code> (default), the parameter will not be send to the
    /// Siteimprove API.
    /// </summary>
    public int? Page { get; set; }

    /// <summary>
    /// Gets or sets the number of items that should be returned for each page. If set to <code>0</code> (default),
    /// the parameter will not be send to the Siteimprove API.
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// Gets or sets the URL pattern. If specified, only pages with a URL that matches the pattern will be
    /// returned. If not specified, all pages will be returned.
    /// </summary>
    public string? Url { get; set; }

    #endregion

    #region Member methods

    public IHttpRequest GetRequest() {

        if (SiteId == 0) throw new PropertyNotSetException(nameof(SiteId));

        // Construct the query string
        IHttpQueryString query = new HttpQueryString();
        if (Page > 0) query.Add("page", Page);
        if (PageSize > 0) query.Add("page_size", PageSize);

        // Initialize a new request
        return HttpRequest.Get($"/v2/sites/{SiteId}/content/pages", query);

    }

    #endregion

}