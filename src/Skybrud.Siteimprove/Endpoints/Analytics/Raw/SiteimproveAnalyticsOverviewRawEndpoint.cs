using System;
using Skybrud.Siteimprove.Exceptions;
using Skybrud.Siteimprove.Options.Analytics;
using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Endpoints.Analytics.Raw {
    
    public class SiteimproveAnalyticsOverviewRawEndpoint {

        #region Properties

        public SiteimproveClient Client { get; private set; }

        public SiteimproveAnalyticsRawEndpoint Analytics { get; private set; }

        #endregion

        #region Constructors

        internal SiteimproveAnalyticsOverviewRawEndpoint(SiteimproveClient client, SiteimproveAnalyticsRawEndpoint analytics) {
            Client = client;
            Analytics = analytics;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of historical data points showing the most common statistics for the site with specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetHistory(int siteId) {
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrlV2 + "sites/" + siteId + "/analytics/overview/history");
        }

        /// <summary>
        /// Gets a list of historical data points showing the most common statistics for the matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetHistory(SiteimproveAnalyticsGetPeriodOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            if (options.SiteId == 0) throw new PropertyNotSetException("options.SiteId");
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrlV2 + "sites/" + options.SiteId + "/analytics/overview/history", options);
        }

        #endregion

    }

}