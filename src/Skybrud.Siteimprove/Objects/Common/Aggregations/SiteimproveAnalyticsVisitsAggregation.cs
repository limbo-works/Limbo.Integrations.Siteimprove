using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Common.Aggregations {
    
    public class SiteimproveAnalyticsVisitsAggregation : SiteimproveObject {

        #region Properties
            
        public int Sum { get; private set; }

        #endregion

        #region Constructors

        private SiteimproveAnalyticsVisitsAggregation(JObject obj) : base(obj) {
            Sum = obj.GetInt32("sum");
        }

        #endregion

        #region Static methods

        public static SiteimproveAnalyticsVisitsAggregation Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsVisitsAggregation(obj);
        }

        #endregion

    }

}