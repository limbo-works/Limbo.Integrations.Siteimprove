using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Integrations.Siteimprove.Models.QualityAssurance {
    
    public class QualityAssuranceSummary : SiteimproveObject {

        #region Properties

        public int BrokenLinks { get; }

        public int ClicksOnBrokenLinks { get; }

        public int Misspellings { get; }

        public int Pages { get; }

        public int PagesAffectedByBrokenLinks { get; }

        public int PagesAffectedByMisspellings { get; }

        public int PotentialMisspellings { get; }

        public string WebApp { get; }

        #endregion

        #region Constructor

        private QualityAssuranceSummary(JObject obj) : base(obj) {
            BrokenLinks = obj.GetInt32("broken_links");
            ClicksOnBrokenLinks = obj.GetInt32("clicks_on_broken_links");
            Misspellings = obj.GetInt32("misspellings");
            Pages = obj.GetInt32("pages");
            PagesAffectedByBrokenLinks = obj.GetInt32("pages_affected_by_broken_links");
            PagesAffectedByMisspellings = obj.GetInt32("pages_affected_by_misspellings");
            PotentialMisspellings = obj.GetInt32("potential_misspellings");
            WebApp = obj.GetString("_siteimprove.webapp.href");
        }

        #endregion

        #region Static methods

        public static QualityAssuranceSummary Parse(JObject obj) {
            return obj == null ? null : new QualityAssuranceSummary(obj);
        }

        #endregion

    }

}