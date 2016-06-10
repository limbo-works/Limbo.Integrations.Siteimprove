using System;
using Skybrud.Siteimprove.Exceptions;
using Skybrud.Siteimprove.Options.Analytics;
using Skybrud.Siteimprove.Options.Analytics.Content;
using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Endpoints.Analytics.Raw {
    
    public class SiteimproveAnalyticsContentRawEndpoint {

        #region Properties

        public SiteimproveClient Client { get; private set; }

        public SiteimproveAnalyticsRawEndpoint Analytics { get; private set; }

        #endregion

        #region Constructors

        internal SiteimproveAnalyticsContentRawEndpoint(SiteimproveClient client, SiteimproveAnalyticsRawEndpoint analytics) {
            Client = client;
            Analytics = analytics;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of the least popular pages for the site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetLeastPopularPages(int siteId) {
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrlV2 + "sites/" + siteId + "/analytics/content/least_popular_pages");
        }

        /// <summary>
        /// Gets a list of the least popular pages for the site and pages matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetLeastPopularPages(SiteimproveAnalyticsGetPopularPagesOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            if (options.SiteId == 0) throw new PropertyNotSetException("options.SiteId");
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrlV2 + "sites/" + options.SiteId + "/analytics/content/least_popular_pages", options);
        }

        /// <summary>
        /// Gets a list of the most popular pages for the site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetMostPopularPages(int siteId) {
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrlV2 + "sites/" + siteId + "/analytics/content/most_popular_pages");
        }

        /// <summary>
        /// Gets a list of the most popular pages for the site and pages matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetMostPopularPages(SiteimproveAnalyticsGetPopularPagesOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            if (options.SiteId == 0) throw new PropertyNotSetException("options.SiteId");
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrlV2 + "sites/" + options.SiteId + "/analytics/content/most_popular_pages", options);
        }

        public SocialHttpResponse GetAllPages(int siteId) {
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrlV2 + "sites/" + siteId + "/analytics/content/all_pages");
        }
        
        public SocialHttpResponse GetAllPages(SiteimproveAnalyticsGetAllPagesOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            if (options.SiteId == 0) throw new PropertyNotSetException("options.SiteId");
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrlV2 + "sites/" + options.SiteId + "/analytics/content/all_pages", options);
        }

        #endregion

    }

}