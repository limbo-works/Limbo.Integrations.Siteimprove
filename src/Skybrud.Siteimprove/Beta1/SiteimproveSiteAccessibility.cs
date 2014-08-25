using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta1 {
    
    public class SiteimproveSiteAccessibility {

        #region Properties

        /// <summary>
        /// Gets the internal JsonObject the object was created from.
        /// </summary>
        public JsonObject JsonObject { get; private set; }

        public int AErrors { get; private set; }
        public int AAErrors { get; private set; }
        public int AAAErrors { get; private set; }

        #endregion

        #region Constructors

        private SiteimproveSiteAccessibility() {
            // Hide default constructor
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a JSON string representing the object.
        /// </summary>
        public string ToJson() {
            return JsonObject == null ? null : JsonObject.ToJson();
        }

        /// <summary>
        /// Saves the object to a JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to save the file.</param>
        public void SaveJson(string path) {
            if (JsonObject != null) JsonObject.SaveJson(path);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Loads an instance from the JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static SiteimproveSiteAccessibility LoadJson(string path) {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets an instance from the specified JSON string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static SiteimproveSiteAccessibility ParseJson(string json) {
            return JsonObject.ParseJson(json, Parse);
        }

        /// <summary>
        /// Gets an instance from the specified <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static SiteimproveSiteAccessibility Parse(JsonObject obj) {
            if (obj == null) return null;
            return new SiteimproveSiteAccessibility {
                JsonObject = obj,
                AErrors = obj.GetInt("aErrors"),
                AAErrors = obj.GetInt("aaErrors"),
                AAAErrors = obj.GetInt("aaaErrors")
            };
        }

        #endregion

    }

}