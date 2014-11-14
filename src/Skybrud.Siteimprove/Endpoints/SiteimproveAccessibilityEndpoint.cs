using Skybrud.Siteimprove.Endpoints.Raw;
using Skybrud.Siteimprove.Objects.Accessibility;
using Skybrud.Siteimprove.Responses;

namespace Skybrud.Siteimprove.Endpoints {

    public class SiteimproveAccessibilityEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; private set; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveAccessibilityRawEndpoint Raw {
            get { return Service.Client.Accessibility; }
        }

        #endregion

        #region Constructors

        internal SiteimproveAccessibilityEndpoint(SiteimproveService service) {
            Service = service;
        }

        #endregion

        #region Methods
        
        /// <summary>
        /// Gets a overview for accessibility.
        /// </summary>
        /// <param name="siteId">The ID of the site.</param>
        public SiteimproveResponse<AccessibilityCollection> GetOverview(int siteId) {
            return SiteimproveHelpers.ParseResponse(Raw.GetOverview(siteId), AccessibilityCollection.Parse);
        }

        #endregion

    }

}