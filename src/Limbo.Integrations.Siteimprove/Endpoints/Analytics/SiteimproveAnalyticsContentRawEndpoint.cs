using System;
using Limbo.Integrations.Siteimprove.Http;
using Limbo.Integrations.Siteimprove.Options.Analytics.Content;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Endpoints.Analytics {

    public class SiteimproveAnalyticsContentRawEndpoint {

        #region Properties

        public SiteimproveHttpClient Client { get; }

        public SiteimproveAnalyticsRawEndpoint Analytics { get; }

        #endregion

        #region Constructors

        internal SiteimproveAnalyticsContentRawEndpoint(SiteimproveHttpClient client, SiteimproveAnalyticsRawEndpoint analytics) {
            Client = client;
            Analytics = analytics;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of the least popular pages for the site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetLeastPopularPages(long siteId) {
            return GetLeastPopularPages(new SiteimproveGetLeastPopularPagesOptions(siteId));
        }

        /// <summary>
        /// Gets a list of the least popular pages for the site and pages matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetLeastPopularPages(SiteimproveGetLeastPopularPagesOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        /// <summary>
        /// Gets a list of the most popular pages for the site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetMostPopularPages(long siteId) {
            return GetMostPopularPages(new SiteimproveGetMostPopularPagesOptions(siteId));
        }

        /// <summary>
        /// Gets a list of the most popular pages for the site and pages matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetMostPopularPages(SiteimproveGetMostPopularPagesOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        /// <summary>
        /// Getsa list of pages of the site with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Analytics/get_sites_site_id_analytics_content_all_pages</cref>
        /// </see>
        public IHttpResponse GetAllPages(long siteId) {
            return GetAllPages(new SiteimproveAnalyticsGetAllPagesOptions(siteId));
        }

        /// <summary>
        /// Getsa list of pages of the site matching the specified <paramref name="options"/>..
        /// </summary>
        /// <returns>Returns an instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://api.siteimprove.com/v2/documentation#!/Analytics/get_sites_site_id_analytics_content_all_pages</cref>
        /// </see>
        public IHttpResponse GetAllPages(SiteimproveAnalyticsGetAllPagesOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        #endregion

    }

}