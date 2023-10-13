using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.Common.Aggregations {
    
    public class SiteimproveAnalyticsSumAggregation : SiteimproveObject {

        #region Properties
            
        public int Sum { get; }

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