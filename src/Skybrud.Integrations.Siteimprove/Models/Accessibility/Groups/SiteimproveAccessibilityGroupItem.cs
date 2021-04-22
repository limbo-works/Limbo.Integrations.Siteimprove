using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Integrations.Siteimprove.Models.Accessibility.Groups {
    
    public class SiteimproveAccessibilityGroupItem : SiteimproveObject {

        #region Properties

        public long Id { get; }

        public int AIssues { get; }

        public int AaIssues { get; }

        public int AaaIssues { get; }

        public string GroupName { get; }

        public int Pages { get; }

        public int PdfIssues { get; }

        public int Users { get; }

        #endregion

        #region Constructors

        private SiteimproveAccessibilityGroupItem(JObject obj) : base(obj) {
            Id = obj.GetInt64("id");
            AIssues = obj.GetInt32("a_issues");
            AaIssues = obj.GetInt32("aa_issues");
            AaaIssues = obj.GetInt32("aaa_issues");
            GroupName = obj.GetString("group_name");
            Pages = obj.GetInt32("pages");
            PdfIssues = obj.GetInt32("pdf_issues");
            Users = obj.GetInt32("users");
        }

        #endregion

        #region Static methods

        public static SiteimproveAccessibilityGroupItem Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAccessibilityGroupItem(obj);
        }

        #endregion

    }

}