using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Integrations.Siteimprove.Objects.Accessibility.Groups {
    
    public class AccessibilityGroupItem : SiteimproveObject {

        #region Properties

        public long Id { get; private set; }

        public int AIssues { get; private set; }

        public int AaIssues { get; private set; }

        public int AaaIssues { get; private set; }

        public string GroupName { get; private set; }

        public int Pages { get; private set; }

        public int PdfIssues { get; private set; }

        public int Users { get; private set; }

        #endregion

        #region Constructors

        private AccessibilityGroupItem(JObject obj) : base(obj) {
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

        public static AccessibilityGroupItem Parse(JObject obj) {
            return obj == null ? null : new AccessibilityGroupItem(obj);
        }

        #endregion

    }

}