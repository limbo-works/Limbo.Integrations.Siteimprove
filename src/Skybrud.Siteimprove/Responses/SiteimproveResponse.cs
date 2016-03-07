﻿using System;
using System.Net;
using Newtonsoft.Json.Linq;
using Skybrud.Siteimprove.Exceptions;
using Skybrud.Siteimprove.Objects;
using Skybrud.Social;
using Skybrud.Social.Http;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Responses {

    /// <summary>
    /// Class representing a response from the Siteimprove API.
    /// </summary>
    public class SiteimproveResponse : SocialResponse {

        #region Properties

        /// <summary>
        /// The Siteimprove API enforces rate limiting. See the API documentation for further information.
        /// </summary>
        /// <see cref="http://developer.siteimprove.com/v1/api-guidelines/" />
        public SiteimproveRateLimiting RateLimiting { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        protected SiteimproveResponse(SocialHttpResponse response) : base(response) {
            RateLimiting = new SiteimproveRateLimiting {
                Limit = Int32.Parse(response.Headers["X-Rate-Limit"]),
                Remaining = Int32.Parse(response.Headers["X-Rate-Remaining"]),
                Reset = Int32.Parse(response.Headers["X-Rate-Reset"].Split(' ')[0])
            };
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Validates the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The response to be validated.</param>
        public static void ValidateResponse(SocialHttpResponse response) {

            // Skip error checking if the server responds with an OK status code
            if (response.StatusCode == HttpStatusCode.OK) return;
            
            throw new Exception("Invalid response received from the Siteimprove API (Status: " + ((int)response.StatusCode) + ")");

        }

        #endregion

        #region Member methods

        /// <summary>
        /// Parses the specified <code>json</code> string into an instance of <code>JObject</code>.
        /// </summary>
        /// <param name="json">The JSON string to be parsed.</param>
        /// <returns>Returns an instance of <code>JObject</code> parsed from the specified <code>json</code> string.</returns>
        protected static JObject ParseJsonObject(string json) {
            return HelpersToBeDeletedWhenWeUpgradeSkybrudSocial.ParseJsonObject(json);
        }

        /// <summary>
        /// Parses the specified <code>json</code> string into an instance of <code>T</code>.
        /// </summary>
        /// <typeparam name="T">The type to be returned.</typeparam>
        /// <param name="json">The JSON string to be parsed.</param>
        /// <param name="func">A callback function/method used for converting an instance of <code>JObject</code> into an instance of <code>T</code>.</param>
        /// <returns>Returns an instance of <code>T</code> parsed from the specified <code>json</code> string.</returns>
        protected static T ParseJsonObject<T>(string json, Func<JObject, T> func) {
            return HelpersToBeDeletedWhenWeUpgradeSkybrudSocial.ParseJsonObject(json, func);
        }

        /// <summary>
        /// Parses the specified <code>json</code> string into an instance of <code>JArray</code>.
        /// </summary>
        /// <param name="json">The JSON string to be parsed.</param>
        /// <returns>Returns an instance of <code>JArray</code> parsed from the specified <code>json</code> string.</returns>
        protected static JArray ParseJsonArray(string json) {
            return HelpersToBeDeletedWhenWeUpgradeSkybrudSocial.ParseJsonArray(json);
        }

        /// <summary>
        /// Parses the specified <code>json</code> string into an array of <code>T</code>.
        /// </summary>
        /// <param name="json">The JSON string to be parsed.</param>
        /// <param name="func">A callback function/method used for converting an instance of <code>JObject</code> into an instance of <code>T</code>.</param>
        /// <returns>Returns an array of <code>T</code> parsed from the specified <code>json</code> string.</returns>
        protected static T[] ParseJsonArray<T>(string json, Func<JObject, T> func) {
            return HelpersToBeDeletedWhenWeUpgradeSkybrudSocial.ParseJsonArray(json, func);
        }

        #endregion

    }

    /// <summary>
    /// Class representing a response from the Siteimprove API.
    /// </summary>
    public class SiteimproveResponse<T> : SiteimproveResponse {

        #region Properties

        /// <summary>
        /// Gets the body of the response.
        /// </summary>
        public T Body { get; protected set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        protected SiteimproveResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Static methods

        [Obsolete]
        public static SiteimproveResponse<T> ParseResponse(SocialHttpResponse response, Func<JsonObject, T> func) {

            if (response == null) return null;

            // Parse the raw JSON response
            JsonObject obj = response.GetBodyAsJsonObject();
            if (obj == null) return null;

            // Validate the response
            if (response.StatusCode != HttpStatusCode.OK) {
                throw new SiteimproveApiException(response, obj.GetString("message"), obj.GetString("type"));
            }

            // Initialize the response object
            return new SiteimproveResponse<T>(response) {
                Body = func(obj)
            };

        }

        #endregion

    }

}