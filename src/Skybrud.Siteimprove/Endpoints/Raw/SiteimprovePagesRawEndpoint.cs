using System;
using Skybrud.Siteimprove.Options.Pages;
using Skybrud.Social.Http;

namespace Skybrud.Siteimprove.Endpoints.Raw {

    public class SiteimprovePagesRawEndpoint {

        #region Properties

        public SiteimproveClient Client { get; private set; }

        #endregion

        #region Constructor

        internal SiteimprovePagesRawEndpoint(SiteimproveClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets detailed information about a page with the specified <code>pageId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPage(int siteId, long pageId) {
            if (siteId <= 0) throw new ArgumentException("Argument siteId must be specified", "siteId");
            if (pageId <= 0) throw new ArgumentException("Argument pageId must be specified", "pageId");
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrl + "sites/" + siteId + "/pages/" + pageId);
        }
        
        /// <summary>
        /// Gets a list of all pages for a site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPages(int siteId) {
            return GetPages(siteId, 0, 0);
        }

        /// <summary>
        /// Gets a list of all pages for a site with the specified <code>siteId</code>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="page">The page to retrieve.</param>
        /// <param name="pageSize">The number of item on each page.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPages(int siteId, int page, int pageSize) {
            return GetPages(new SiteimproveGetPagesOptions {
                SiteId = siteId,
                Page = page,
                PageSize = pageSize
            });
        }

        /// <summary>
        /// Gets a list of all pages for a site matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPages(SiteimproveGetPagesOptions options) {
            return Client.DoHttpGetRequest(SiteimproveClient.ApiUrl + "sites/" + options.SiteId + "/pages", options);
        }

        #endregion

    }

}