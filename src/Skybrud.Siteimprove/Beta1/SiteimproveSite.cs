using Skybrud.Siteimprove.Beta1.Site;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta1 {

    public class SiteimproveSite {

        #region Properties

        /// <summary>
        /// Gets the internal JsonObject the object was created from.
        /// </summary>
        public JsonObject JsonObject { get; private set; }

        public SiteAnalytics Analytics { get; private set; }
        public SiteimproveSiteAccessibility Accessibility { get; private set; }

        #endregion

        #region Constructors

        private SiteimproveSite() {
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
        /// Loads a site from the JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static SiteimproveSite LoadJson(string path) {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets a site from the specified JSON string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static SiteimproveSite ParseJson(string json) {
            return JsonObject.ParseJson(json, Parse);
        }

        /// <summary>
        /// Gets a site from the specified <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static SiteimproveSite Parse(JsonObject obj) {
            if (obj == null) return null;
            return new SiteimproveSite {
                JsonObject = obj,
                Analytics = obj.GetObject("analytics", SiteAnalytics.Parse),
                Accessibility = obj.GetObject("accessibility", SiteimproveSiteAccessibility.Parse)
            };
        }

        /// <summary>
        /// Gets an array of sites from the specified <var>JsonArray</var>.
        /// </summary>
        /// <param name="array">The instance of <var>JsonArray</var> to parse.</param>
        public static SiteimproveSite[] ParseMultiple(JsonArray array) {
            return array == null ? new SiteimproveSite[0] : array.ParseMultiple(Parse);
        }

        #endregion

    }

}
