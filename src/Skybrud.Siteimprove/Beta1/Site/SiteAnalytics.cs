using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta1.Site {
    
    public class SiteAnalytics {
        
        #region Properties

        /// <summary>
        /// Gets the internal JsonObject the object was created from.
        /// </summary>
        public JsonObject JsonObject { get; private set; }

        public SiteAnalyticsEntry Yesterday { get; private set; }

        public SiteAnalyticsEntry LastSevenDays { get; private set; }

        public SiteAnalyticsEntry LastMonth { get; private set; }

        #endregion

        #region Constructor

        internal SiteAnalytics() {
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
        /// Loads an instance of <var>SiteAnalytics</var> from the JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static SiteAnalytics LoadJson(string path) {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>SiteAnalytics</var> from the specified JSON string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static SiteAnalytics ParseJson(string json) {
            return JsonObject.ParseJson(json, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>SiteAnalytics</var> from the specified <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static SiteAnalytics Parse(JsonObject obj) {
            return new SiteAnalytics {
                JsonObject = obj,
                Yesterday = obj.GetObject("yesterday", SiteAnalyticsEntry.Parse),
                LastSevenDays = obj.GetObject("lastSevenDays", SiteAnalyticsEntry.Parse),
                LastMonth = obj.GetObject("lastMonth", SiteAnalyticsEntry.Parse)
            };
        }

        #endregion

    }

}
