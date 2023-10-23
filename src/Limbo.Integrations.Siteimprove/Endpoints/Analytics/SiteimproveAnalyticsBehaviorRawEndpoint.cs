using System;
using Limbo.Integrations.Siteimprove.Http;
using Limbo.Integrations.Siteimprove.Options.Analytics.Behavior;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Endpoints.Analytics;

public class SiteimproveAnalyticsBehaviorRawEndpoint {

    #region Properties

    public SiteimproveHttpClient Client { get; }

    public SiteimproveAnalyticsRawEndpoint Analytics { get; }

    #endregion

    #region Constructors

    internal SiteimproveAnalyticsBehaviorRawEndpoint(SiteimproveHttpClient client, SiteimproveAnalyticsRawEndpoint analytics) {
        Client = client;
        Analytics = analytics;
    }

    #endregion

    #region Member methods

    /// <summary>
    /// Gets a list with historical data for the average duration a user spends on the site with the specified <code>siteId</code>.
    /// </summary>
    /// <param name="siteId">The ID of the site.</param>
    /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
    public IHttpResponse GetVisitLengthHistory(long siteId) {
        return GetVisitLengthHistory(new SiteimproveGetVisitLengthHistoryOptions(siteId));
    }

    /// <summary>
    /// Gets a list with historical data for the average duration a user spends on the site matching the specified <code>options</code>.
    /// </summary>
    /// <param name="options">The options for the call to the API.</param>
    /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
    public IHttpResponse GetVisitLengthHistory(SiteimproveGetVisitLengthHistoryOptions options) {
        if (options == null) throw new ArgumentNullException(nameof(options));
        return Client.GetResponse(options);
    }

    #endregion

}