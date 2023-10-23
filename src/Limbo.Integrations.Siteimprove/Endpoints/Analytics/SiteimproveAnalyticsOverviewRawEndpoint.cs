using System;
using Limbo.Integrations.Siteimprove.Http;
using Limbo.Integrations.Siteimprove.Options.Analytics.Overview;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Endpoints.Analytics;

public class SiteimproveAnalyticsOverviewRawEndpoint {

    #region Properties

    public SiteimproveHttpClient Client { get; }

    public SiteimproveAnalyticsRawEndpoint Analytics { get; }

    #endregion

    #region Constructors

    internal SiteimproveAnalyticsOverviewRawEndpoint(SiteimproveHttpClient client, SiteimproveAnalyticsRawEndpoint analytics) {
        Client = client;
        Analytics = analytics;
    }

    #endregion

    #region Member methods

    /// <summary>
    /// Gets a list of historical data points showing the most common statistics for the site with specified <code>siteId</code>.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
    /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
    public IHttpResponse GetHistory(long siteId) {
        return GetHistory(new SiteimproveGetHistoryOptions(siteId));
    }

    /// <summary>
    /// Gets a list of historical data points showing the most common statistics for the matching the specified <code>options</code>.
    /// </summary>
    /// <param name="options">The options for the call to the API.</param>
    /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
    public IHttpResponse GetHistory(SiteimproveGetHistoryOptions options) {
        if (options == null) throw new ArgumentNullException(nameof(options));
        return Client.GetResponse(options);
    }

    /// <summary>
    /// Gets a summary with the most common statistics for the site with the specified <code>siteId</code>.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
    /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
    public IHttpResponse GetSummary(long siteId) {
        return GetSummary(new SiteimproveGetSummaryOverviewOptions(siteId));
    }

    /// <summary>
    /// Gets a summary with the most common statistics for the site matching the specified <code>options</code>.
    /// </summary>
    /// <param name="options">The options for the call to the API.</param>
    /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
    public IHttpResponse GetSummary(SiteimproveGetSummaryOverviewOptions options) {
        if (options == null) throw new ArgumentNullException(nameof(options));
        return Client.GetResponse(options);
    }

    #endregion

}