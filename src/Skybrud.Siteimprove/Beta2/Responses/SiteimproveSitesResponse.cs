using System;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Skybrud.Siteimprove.Beta2.Objects;
using Skybrud.Siteimprove.Skybrud.Social;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Beta2.Responses {

    public class SiteimproveSitesResponse : SiteimproveResponse {

        #region Properties

        /// <summary>
        /// Gets the internal JsonObject the object was created from.
        /// </summary>
        [JsonIgnore]
        public JsonObject JsonObject { get; private set; }

        /// <summary>
        /// The total amount of sites.
        /// </summary>
        public int Total { get; private set; }

        /// <summary>
        /// Array of sites returned.
        /// </summary>
        public SiteimproveSiteSummary[] Sites { get; private set; }

        /// <summary>
        /// Gets whether there are any further pages.
        /// </summary>
        public bool HasMore { get; private set; }

        /// <summary>
        /// Gets the URL for the next page if there are any further sites, otherwise <code>NULL</code>.
        /// </summary>
        public string Next { get; private set; }

        /// <summary>
        /// Gets the URL for the pevious page if the offset is greater than <code>0</code>, otherwise <code>NULL</code>.
        /// </summary>
        public string Previous { get; private set; }

        #endregion

        #region Static methods

        public static SiteimproveSitesResponse Parse(SocialHttpResponse response) {
            Validate(response);
            return response == null ? null : Parse(JsonObject.ParseJson(response.Body));
        }
        
        public static SiteimproveSitesResponse Parse(JsonObject obj) {

            // Check if NULL
            if (obj == null) return null;

            // TODO: Validate the response

            // Parse the JSON object
            JsonObject sites = obj.GetObject("sites");
            return new SiteimproveSitesResponse {
                JsonObject = obj,
                Total = obj.GetInt("results"),
                Sites = (
                    from pair in sites.Dictionary
                    select SiteimproveSiteSummary.Parse(pair.Key, sites.GetObject(pair.Key))
                ).ToArray(),
                HasMore = obj.GetBoolean("has_more"),
                Next = obj.GetString("next"),
                Previous = obj.GetString("prev")
            };

        }

        #endregion

    }

}
