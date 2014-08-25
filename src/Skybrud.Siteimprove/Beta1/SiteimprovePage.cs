using System;
using Skybrud.Siteimprove.Beta1.Page;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta1 {

    public class SiteimprovePage {

        #region Properties

        /// <summary>
        /// Gets the internal JsonObject the object was created from.
        /// </summary>
        public JsonObject JsonObject { get; private set; }

        public long Id { get; private set; }

        public string Url { get; private set; }

        public string Title { get; private set; }

        public string PageReport { get; private set; }

        public string Checked { get; private set; }

        public PageQualityAssurance QualityAssurance { get; private set; }

        public PageAnalytics Analytics { get; private set; }

        #endregion

        #region Constructor

        internal SiteimprovePage() {
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
        /// Loads an instance of <var>SiteimprovePage</var> from the JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static SiteimprovePage LoadJson(string path) {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>SiteimprovePage</var> from the specified JSON string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static SiteimprovePage ParseJson(string json) {
            return JsonObject.ParseJson(json, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>SiteimprovePage</var> from the specified <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static SiteimprovePage Parse(JsonObject obj) {
            if (obj.HasValue("message")) throw new Exception(obj.GetString("message"));
            return new SiteimprovePage {
                JsonObject = obj,
                Id = obj.GetLong("id"),
                Url = obj.GetString("url"),
                Title = obj.GetString("title"),
                PageReport = obj.GetString("pageReport"),
                Checked = obj.GetString("checked"),
                QualityAssurance = obj.GetObject("qualityAssurance", PageQualityAssurance.Parse),
                Analytics = obj.GetObject("analytics", PageAnalytics.Parse)
            };
        }

        #endregion

    }

}