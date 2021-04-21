using System;
using Skybrud.Essentials.Common;
using Skybrud.Integrations.Siteimprove.Options.Analytics;
using Skybrud.Social.Http;

namespace Skybrud.Integrations.Siteimprove.Endpoints.Analytics.Raw {
    
    public class SiteimproveAnalyticsBehaviorRawEndpoint {

        #region Properties

        public SiteimproveClient Client { get; private set; }

        public SiteimproveAnalyticsRawEndpoint Analytics { get; private set; }

        #endregion

        #region Constructors

        internal SiteimproveAnalyticsBehaviorRawEndpoint(SiteimproveClient client, SiteimproveAnalyticsRawEndpoint analytics) {
            Client = client;
            Analytics = analytics;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list with historical data for the average duration a user spends on the site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetVisitLengthHistory(int siteId) {
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrlV2 + "sites/" + siteId + "/analytics/behavior/visit_length/history");
        }

        /// <summary>
        /// Gets a list with historical data for the average duration a user spends on the site matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetVisitLengthHistory(SiteimproveAnalyticsGetPeriodOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            if (options.SiteId == 0) throw new PropertyNotSetException("options.SiteId");
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrlV2 + "sites/" + options.SiteId + "/analytics/behavior/visit_length/history", options);
        }

        #endregion

    }

}