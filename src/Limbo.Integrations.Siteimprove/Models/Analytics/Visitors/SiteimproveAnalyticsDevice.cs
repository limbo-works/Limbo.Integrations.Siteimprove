using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.Analytics.Visitors {
    
    public class SiteimproveAnalyticsDevice : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the number of visits registered for the page.
        /// </summary>
        public int Visits { get; }

        /// <summary>
        /// Gets the bounce rate is an indication of how many visitors only perform a single page view.
        /// </summary>
        public float BounceRate { get; }

        public string DeviceType { get; }

        #endregion

        #region Constructors

        private SiteimproveAnalyticsDevice(JObject obj) : base(obj) {
            Visits = obj.GetInt32("visits");
            BounceRate = obj.GetFloat("bounce_rate");
            DeviceType = obj.GetString("device_type");
        }

        #endregion

        #region Static methods

        public static SiteimproveAnalyticsDevice Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsDevice(obj);
        }

        #endregion

    }

}