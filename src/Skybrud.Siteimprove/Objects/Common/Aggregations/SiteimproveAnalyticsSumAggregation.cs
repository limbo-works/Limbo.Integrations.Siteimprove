using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Common.Aggregations {
    
    public class SiteimproveAnalyticsSumAggregation : SiteimproveObject {

        #region Properties
            
        public int Sum { get; private set; }

        #endregion

        #region Constructors

        private SiteimproveAnalyticsSumAggregation(JObject obj) : base(obj) {
            Sum = obj.GetInt32("sum");
        }

        #endregion

        #region Static methods

        public static SiteimproveAnalyticsSumAggregation Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsSumAggregation(obj);
        }

        #endregion

    }

}