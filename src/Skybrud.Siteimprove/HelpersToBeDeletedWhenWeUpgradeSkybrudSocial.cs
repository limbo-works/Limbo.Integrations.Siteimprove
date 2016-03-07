﻿using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Skybrud.Siteimprove {
    
    public class HelpersToBeDeletedWhenWeUpgradeSkybrudSocial {

        #region JSON

        /// <summary>
        /// Parses the specified <code>json</code> string into an instance <see cref="JObject"/>.
        /// </summary>
        /// <param name="json">The JSON string to be parsed.</param>
        /// <returns>Returns an instance of <see cref="JObject"/> parsed from the specified <code>json</code> string.</returns>
        public static JObject ParseJsonObject(string json) {

            // JSON.net is automatically parsing strings that look like dates into in actual dates so that we can't
            // really read as strings without some localization going on. Since this is kinda annoying an we don't
            // really need it, we can luckily disable it with the lines below
            return JObject.Load(new JsonTextReader(new StringReader(json)) {
                DateParseHandling = DateParseHandling.None
            });

        }

        /// <summary>
        /// Parses the specified <code>json</code> string into an instance of <see cref="T"/>.
        /// </summary>
        /// <typeparam name="T">The type to be returned.</typeparam>
        /// <param name="json">The JSON string to be parsed.</param>
        /// <param name="func">A callback function/method used for converting an instance of <see cref="JObject"/> into an instance of <see cref="T"/>.</param>
        /// <returns>Returns an instance of <see cref="T"/> parsed from the specified <code>json</code> string.</returns>
        public static T ParseJsonObject<T>(string json, Func<JObject, T> func) {
            return func(ParseJsonObject(json));
        }

        /// <summary>
        /// Parses the specified <code>json</code> string into an instance of <see cref="JArray"/>.
        /// </summary>
        /// <param name="json">The JSON string to be parsed.</param>
        /// <returns>Returns an instance of <see cref="JArray"/> parsed from the specified <code>json</code> string.</returns>
        public static JArray ParseJsonArray(string json) {

            // JSON.net is automatically parsing strings that look like dates into in actual dates so that we can't
            // really read as strings without some localization going on. Since this is kinda annoying an we don't
            // really need it, we can luckily disable it with the lines below
            return JArray.Load(new JsonTextReader(new StringReader(json)) {
                DateParseHandling = DateParseHandling.None
            });

        }

        /// <summary>
        /// Parses the specified <code>json</code> string into an array of <see cref="T"/>.
        /// </summary>
        /// <param name="json">The JSON string to be parsed.</param>
        /// <param name="func">A callback function/method used for converting an instance of <see cref="JObject"/> into an instance of <see cref="T"/>.</param>
        /// <returns>Returns an array of <see cref="T"/> parsed from the specified <code>json</code> string.</returns>
        public static T[] ParseJsonArray<T>(string json, Func<JObject, T> func) {
            return (
                from JObject item in ParseJsonArray(json)
                select func(item)
            ).ToArray();
        }

        #endregion

    }

}