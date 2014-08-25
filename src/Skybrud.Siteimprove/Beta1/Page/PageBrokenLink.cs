using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta1.Page {

    public class PageBrokenLink {

        #region Properties

        /// <summary>
        /// Gets the internal JsonObject the object was created from.
        /// </summary>
        public JsonObject JsonObject { get; private set; }

        public string Url { get; private set; }

        public string BrokenSince { get; private set; }

        public int? Clicks { get; private set; }

        public string Response { get; private set; }

        #endregion

        #region Constructor

        internal PageBrokenLink() {
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
        /// Loads an instance of <var>PageBrokenLink</var> from the JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static PageBrokenLink LoadJson(string path) {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>PageBrokenLink</var> from the specified JSON string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static PageBrokenLink ParseJson(string json) {
            return JsonObject.ParseJson(json, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>PageBrokenLink</var> from the specified <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static PageBrokenLink Parse(JsonObject obj) {
            return new PageBrokenLink {
                JsonObject = obj,
                Url = obj.GetString("url"),
                BrokenSince = obj.GetString("brokenSince"),
                Clicks = obj.HasValue("clicks") ? (int?) obj.GetInt("clicks") : null,
                Response = obj.GetString("response")
            };
        }

        #endregion

    }

}