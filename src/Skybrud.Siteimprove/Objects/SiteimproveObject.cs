﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Skybrud.Siteimprove.Objects {

    /// <summary>
    /// Class representing a basic object from the Siteimprove API derived from an instance of <see cref="JObject"/>.
    /// </summary>
    public class SiteimproveObject {

        #region Properties

        /// <summary>
        /// Gets a reference to the internal <see cref="JObject"/> the object was created from.
        /// </summary>
        [JsonIgnore]
        public JObject JObject { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        protected SiteimproveObject(JObject obj) {
            JObject = obj;
        }

        #endregion

    }

}