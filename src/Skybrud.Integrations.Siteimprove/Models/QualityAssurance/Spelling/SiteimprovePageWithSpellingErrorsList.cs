using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Integrations.Siteimprove.Models.QualityAssurance.Spelling {
    
    public class SiteimprovePageWithSpellingErrorsList : SiteimproveObject {

        #region Properties

        public SiteimprovePageWithSpellingErrors[] Items { get; }

        public int TotalItems { get; }

        public int TotalPages { get; }

        #endregion

        #region Constructors

        private SiteimprovePageWithSpellingErrorsList(JObject json) : base(json) {
            Items = json.GetArrayItems("items", SiteimprovePageWithSpellingErrors.Parse);
            TotalItems = json.GetInt32("total_items");
            TotalPages = json.GetInt32("total_pages");
        }

        #endregion


        #region Static methods

        public static SiteimprovePageWithSpellingErrorsList Parse(JObject json) {
            return json == null ? null : new SiteimprovePageWithSpellingErrorsList(json);
        }

        #endregion

    }

}