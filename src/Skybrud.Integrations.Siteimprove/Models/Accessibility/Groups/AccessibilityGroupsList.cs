using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Integrations.Siteimprove.Models.Accessibility.Groups {
    
    public class AccessibilityGroupsList : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the items on the current page.
        /// </summary>
        public AccessibilityGroupItem[] Items { get; private set; }

        /// <summary>
        /// Gets the total amount of items matching the options sent to the API.
        /// </summary>
        public int TotalItems { get; private set; }

        /// <summary>
        /// Gets the total amount of pages matching the options sent to the API.
        /// </summary>
        public int TotalPages { get; private set; }

        #endregion

        #region Constructors

        private AccessibilityGroupsList(JObject obj) : base(obj) {
            Items = obj.GetArrayItems("items", AccessibilityGroupItem.Parse);
            TotalItems = obj.GetInt32("total_items");
            TotalPages = obj.GetInt32("total_pages");
        }

        #endregion

        #region Static methods

        public static AccessibilityGroupsList Parse(JObject obj) {
            return obj == null ? null : new AccessibilityGroupsList(obj);
        }

        #endregion

    }

}