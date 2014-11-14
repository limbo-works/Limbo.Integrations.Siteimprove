using System;
using Skybrud.Social;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Objects.QualityAssurance.Spelling.Overview {

    /// <summary>
    /// Describes the amount of broken links a specified time.
    /// </summary>
    public class SpellingResult : SocialJsonObject {

        #region Properties

        /// <summary>
        /// Gets the UTC timestamp for the time the site was checked.
        /// </summary>
        public DateTime Timestamp { get; private set; }

        /// <summary>
        /// Gets the amount of misspelled words.
        /// </summary>
        public int MisspellingCount { get; private set; }

        /// <summary>
        /// Gets the amount of pages 
        /// </summary>
        public int PotentialMisspellingCount { get; private set; }

        #endregion

        #region Constructor

        private SpellingResult(JsonObject obj) : base(obj) { }

        #endregion

        #region Static methods

        public static SpellingResult Parse(JsonObject obj) {
            if (obj == null) return null;
            return new SpellingResult(obj) {
                Timestamp = obj.GetDateTime("timestamp"),
                MisspellingCount = obj.GetInt32("misspelling_count"),
                PotentialMisspellingCount = obj.GetInt32("potential_misspelling_count")
            };
        }

        #endregion

    }

}
