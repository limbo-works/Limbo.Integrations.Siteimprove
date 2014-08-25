using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta1.Site {

    public class SiteAnalyticsEntry {

        #region Properties

        /// <summary>
        /// Gets the internal JsonObject the object was created from.
        /// </summary>
        public JsonObject JsonObject { get; private set; }

        public string Start { get; private set; }

        public string End { get; private set; }

        public int PageViews { get; private set; }

        public int Sessions { get; private set; }

        public int UniqueSessions { get; private set; }

        public SiteAnalyticsPage[] MostPopularPages { get; private set; }

        #endregion

        #region Constructor

        internal SiteAnalyticsEntry() {
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
        /// Loads an instance of <var>SiteAnalyticsEntry</var> from the JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static SiteAnalyticsEntry LoadJson(string path) {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>SiteAnalyticsEntry</var> from the specified JSON string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static SiteAnalyticsEntry ParseJson(string json) {
            return JsonObject.ParseJson(json, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>SiteAnalyticsEntry</var> from the specified <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static SiteAnalyticsEntry Parse(JsonObject obj) {
            return new SiteAnalyticsEntry {
                JsonObject = obj,
                Start = obj.GetString("start"),
                End = obj.GetString("end"),
                PageViews = obj.GetInt("pageViews"),
                Sessions = obj.GetInt("sessions"),
                UniqueSessions = obj.GetInt("uniqueSessions"),
                MostPopularPages = obj.GetArray("mostPopularPages", SiteAnalyticsPage.Parse)
            };
        }

        #endregion

    }
}