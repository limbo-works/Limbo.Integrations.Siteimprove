using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta1.Site {
    
    public class SiteAnalyticsPage {

        #region Properties

        /// <summary>
        /// Gets the internal JsonObject the object was created from.
        /// </summary>
        public JsonObject JsonObject { get; private set; }

        public string Url { get; private set; }

        public string Title { get; private set; }

        public int PageViews { get; private set; }

        public float? BounceRate { get; private set; }

        public float PageScore { get; private set; }

        #endregion

        #region Constructor

        internal SiteAnalyticsPage() {
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
        /// Loads an instance of <var>SiteAnalyticsPage</var> from the JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static SiteAnalyticsPage LoadJson(string path) {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>SiteAnalyticsPage</var> from the specified JSON string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static SiteAnalyticsPage ParseJson(string json) {
            return JsonObject.ParseJson(json, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>SiteAnalyticsPage</var> from the specified <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static SiteAnalyticsPage Parse(JsonObject obj) {
            return new SiteAnalyticsPage {
                JsonObject = obj,
                Url = obj.GetString("url"),
                Title = obj.GetString("title"),
                PageViews = obj.GetInt("pageViews"),
                BounceRate = obj.GetFloat("bounceRate"),
                PageScore = obj.GetInt("pageScore")
            };
        }

        #endregion

    }

}