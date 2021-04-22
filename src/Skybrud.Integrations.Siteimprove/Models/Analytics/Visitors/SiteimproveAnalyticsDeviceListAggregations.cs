using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Integrations.Siteimprove.Models.Common.Aggregations;

namespace Skybrud.Integrations.Siteimprove.Models.Analytics.Visitors {
    
    public class SiteimproveAnalyticsDeviceListAggregations : SiteimproveObject {

        #region Properties
            
        public SiteimproveAnalyticsSumAggregation Visits { get; }

        #endregion

        #region Constructors

        private SiteimproveAnalyticsDeviceListAggregations(JObject obj) : base(obj) {
            Visits = obj.GetObject("visits", SiteimproveAnalyticsSumAggregation.Parse);
        }

        #endregion

        #region Static methods

        public static SiteimproveAnalyticsDeviceListAggregations Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsDeviceListAggregations(obj);
        }

        #endregion

    }

}