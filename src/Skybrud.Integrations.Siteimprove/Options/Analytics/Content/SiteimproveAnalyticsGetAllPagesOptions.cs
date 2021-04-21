using System;
using Skybrud.Social.Http;

namespace Skybrud.Integrations.Siteimprove.Options.Analytics.Content {

    /// <see>
    ///     <cref>https://api.siteimprove.com/v2/documentation#!/Analytics/get_sites_site_id_analytics_content_all_pages</cref>
    /// </see>
    public class SiteimproveAnalyticsGetAllPagesOptions : SiteimproveAnalyticsGetPeriodOptions {

        #region Properties

        /// <summary>
        /// Gets or sets a text based query that all returned items should match.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Gets or sets the field that <see cref="Query"/> should match. 
        /// </summary>
        public SiteimproveAnalyticsGetAllPagesField SearchIn { get; set; }

        #endregion

        #region Member methods

        public override SocialQueryString GetQueryString() {
            SocialQueryString query = base.GetQueryString();
            if (!String.IsNullOrWhiteSpace(Query)) {
                query.Add("query", Query);
                query.Add("search_in", SearchIn.ToString().ToLower());
            }
            return query;
        }

        #endregion

    }

}