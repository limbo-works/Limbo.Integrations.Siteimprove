using Newtonsoft.Json;
using Skybrud.Siteimprove.Beta2.Objects.Site;
using Skybrud.Siteimprove.Beta2.Responses;
using Skybrud.Social.Http;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta2.Objects {

    public class SiteimproveSite {

        #region Properties

        /// <summary>
        /// Gets the internal JsonObject the object was created from.
        /// </summary>
        [JsonIgnore]
        public JsonObject JsonObject { get; private set; }

        [JsonProperty("site_id")]
        public int Id { get; private set; }

        [JsonProperty("site_name")]
        public string Name { get; private set; }

        [JsonProperty("site_root_domain")]
        public string Domain { get; private set; }

        [JsonProperty("quality_assurance")]
        public QualityAssurance QualityAssurance { get; private set; }

        [JsonProperty("analytics")]
        public Analytics Analytics { get; private set; }

        [JsonProperty("accessibility")]
        public Accessibility Accessibility { get; private set; }

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

        public static SiteimproveSite Parse(SocialHttpResponse response) {
            SiteimproveResponse.Validate(response);
            return response == null ? null : Parse(JsonObject.ParseJson(response.Body));
        }

        /// <summary>
        /// Gets a site from the specified <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static SiteimproveSite Parse(JsonObject obj) {
        
            if (obj == null) return null;
            
            return new SiteimproveSite {
                JsonObject = obj,
                Id = obj.GetInt("site_id"),
                Name = obj.GetString("site_name"),
                Domain = obj.GetString("site_root_domain"),
                QualityAssurance = obj.GetObject("quality_assurance", QualityAssurance.Parse),
                Analytics = obj.GetObject("analytics", Analytics.Parse),
                Accessibility = obj.GetObject("accessibility", Accessibility.Parse)
            };
        
        }

        #endregion

    }

}
