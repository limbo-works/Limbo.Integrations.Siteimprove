using Skybrud.Essentials.Common;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces;

namespace Skybrud.Siteimprove.Options.QualityAssurance.BrokenLinks {

    public class SiteimproveGetQualityAssuranceSummaryOptions : IGetOptions {

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

        public SocialQueryString GetQueryString() {
            if (SiteId == 0) throw new PropertyNotSetException("SiteId");
            SocialQueryString query = new SocialQueryString();
            query.Add("site_id", SiteId);
            if (GroupId > 0) query.Add("group_id", GroupId);
            return query;
        }

        #endregion

    }

}