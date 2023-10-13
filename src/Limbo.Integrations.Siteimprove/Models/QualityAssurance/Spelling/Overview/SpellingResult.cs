using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.QualityAssurance.Spelling.Overview {

    /// <summary>
    /// Describes the amount of broken links a specified time.
    /// </summary>
    public class SiteimproveSpellingResult : SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets the UTC timestamp for the time the site was checked.
        /// </summary>
        public DateTime Timestamp { get; }

        /// <summary>
        /// Gets the number of misspellings.
        /// </summary>
        public int Misspellings { get; }

        /// <summary>
        /// Gets the number of potential misspellings.
        /// </summary>
        public int PotentialMisspellings { get; }

        #endregion

        #region Constructor

        private SiteimproveSpellingResult(JObject obj) : base(obj) {
            Timestamp = obj.GetDateTime("timestamp");
            Misspellings = obj.GetInt32("misspellings");
            PotentialMisspellings = obj.GetInt32("potential_misspellings");
        }

        #endregion

        #region Static methods

        public static SiteimproveSpellingResult Parse(JObject obj) {
            return obj == null ? null : new SiteimproveSpellingResult(obj);
        }

        #endregion

    }

}