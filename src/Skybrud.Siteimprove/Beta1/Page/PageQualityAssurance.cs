using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta1.Page {

    public class PageQualityAssurance {

        #region Properties

        /// <summary>
        /// Gets the internal JsonObject the object was created from.
        /// </summary>
        public JsonObject JsonObject { get; private set; }

        public PageBrokenLink[] BrokenLinks { get; private set; }

        public PageMisspelling[] PotentialMisspellings { get; private set; }

        #endregion

        #region Constructor

        internal PageQualityAssurance() {
            // Hide default constructor
        }

        #endregion

        #region Members methods

        /// <summary>
        /// Gets a JSON string representing the object.
        /// </summary>
        public string ToJson() {
            return JsonObject == null ? null : JsonObject.ToJson();
        }

        /// <summary>
        /// Saves the object to a JSON file at the specified <var>path</var>.
        /// </summary>
        public void SaveJson(string path) {
            if (JsonObject != null) JsonObject.SaveJson(path);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Loads an instance of <var>PageQualityAssurance</var> from the JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static PageQualityAssurance LoadJson(string path) {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>PageQualityAssurance</var> from the specified JSON string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static PageQualityAssurance ParseJson(string json) {
            return JsonObject.ParseJson(json, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>PageQualityAssurance</var> from the specified <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static PageQualityAssurance Parse(JsonObject obj) {
            return new PageQualityAssurance {
                JsonObject = obj,
                BrokenLinks = obj.GetArray("brokenLinks", PageBrokenLink.Parse),
                PotentialMisspellings = obj.GetArray("potentialMisspellings", PageMisspelling.Parse)
            };
        }

        #endregion

    }

}