using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;

namespace Limbo.Integrations.Siteimprove.Options.QualityAssurance.BrokenLinks {

    public class SiteimproveGetQualityAssuranceSummaryOptions : IHttpRequestOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the ID of the site.
        /// </summary>
        public long SiteId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the group.
        /// </summary>
        public long GroupId { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public SiteimproveGetQualityAssuranceSummaryOptions() { }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="siteId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        public SiteimproveGetQualityAssuranceSummaryOptions(long siteId) {
            SiteId = siteId;
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="siteId"/> and <paramref name="groupId"/>.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        /// <param name="groupId">The maximum amount of items per page.</param>
        public SiteimproveGetQualityAssuranceSummaryOptions(long siteId, long groupId) {
            SiteId = siteId;
            GroupId = groupId;
        }

        #endregion

        #region Member methods

        public IHttpRequest GetRequest() {

            if (SiteId == 0) throw new PropertyNotSetException(nameof(SiteId));

            IHttpQueryString query = new HttpQueryString();

            // TODO: Is this necessary? The site ID is already a part of the URL
            query.Add("site_id", SiteId);

            if (GroupId > 0) query.Add("group_id", GroupId);

            // Initialize a new request
            return HttpRequest.Get($"/v2/sites/{SiteId}/quality_assurance/overview/summary", query);

        }

        #endregion


    }

}