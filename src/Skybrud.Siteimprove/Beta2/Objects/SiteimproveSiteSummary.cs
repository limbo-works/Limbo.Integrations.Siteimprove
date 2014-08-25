using System;
using Newtonsoft.Json;
using Skybrud.Siteimprove.Beta2.Objects.SiteSummary;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta2.Objects {

    public class SiteimproveSiteSummary {

        #region Properties

        /// <summary>
        /// Gets the internal JsonObject the object was created from.
        /// </summary>
        [JsonIgnore]
        public JsonObject JsonObject { get; private set; }
        
        /// <summary>
        /// Gets the ID of the site.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; private set; }

        /// <summary>
        /// Gets the API URL of the site.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; private set; }

        /// <summary>
        /// Gets the name of the site.
        /// </summary>
        [JsonProperty("site_name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the root domain of the site.
        /// </summary>
        [JsonProperty("site_root_domain")]
        public string Domain { get; private set; }

        [JsonProperty("quality_assurance")]
        public QualityAssurance QualityAssurance { get; private set; }

        [JsonProperty("accessibility")]
        public Accessibility Accessibility { get; private set; }

        [JsonProperty("analytics")]
        public Analytics Analytics { get; private set; }

        #endregion

        #region Constructors

        private SiteimproveSiteSummary() {
            // Hide default constructor
        }

        #endregion

        #region Static methods
        
        public static SiteimproveSiteSummary Parse(string siteId, JsonObject obj) {
            return Parse(Int32.Parse(siteId), obj);
        }

        public static SiteimproveSiteSummary Parse(int siteId, JsonObject obj) {

            // Check if NULL
            if (obj == null) return null;

            // Parse the JSON object
            return new SiteimproveSiteSummary {
                JsonObject = obj,
                Id = siteId,
                Url = obj.GetString("url"),
                Name = obj.GetString("site_name"),
                Domain = obj.GetString("site_root_domain"),
                QualityAssurance = obj.GetObject("quality_assurance", QualityAssurance.Parse),
                Accessibility = obj.GetObject("accessibility", Accessibility.Parse),
                Analytics = obj.GetObject("analytics", Analytics.Parse)
            };

        }

        public static SiteimproveSiteSummary Parse(JsonObject obj) {

            // Check if NULL
            if (obj == null) return null;

            // Parse the JSON object
            return new SiteimproveSiteSummary {
                JsonObject = obj,
                Id = obj.GetInt("id"),
                Url = obj.GetString("url"),
                Name = obj.GetString("site_name"),
                Domain = obj.GetString("site_root_domain"),
                QualityAssurance = obj.GetObject("quality_assurance", QualityAssurance.Parse),
                Accessibility = obj.GetObject("accessibility", Accessibility.Parse),
                Analytics = obj.GetObject("analytics", Analytics.Parse)
            };

        }

        #endregion

    }

}
