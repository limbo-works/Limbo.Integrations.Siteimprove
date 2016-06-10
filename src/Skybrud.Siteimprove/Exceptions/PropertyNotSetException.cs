using System;

namespace Skybrud.Siteimprove.Exceptions {

    /// <summary>
    /// Class representing an exception for a property that is not set.
    /// </summary>
    public class PropertyNotSetException : Exception {

        // Copied from: https://github.com/abjerner/Skybrud.Social/blob/2ae017179d69d942d1c43da6985bdeb6a651e049/src/Skybrud.Social.Core/Exceptions/PropertyNotSetException.cs
        // We should use the "PropertyNotSetException" class in Skybrud.Social.Core instead once we update the reference

        #region Properties

        /// <summary>
        /// Gets the name of the property.
        /// </summary>
        public string PropertyName { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new exception for the property with the specified <code>propertyName</code>.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        public PropertyNotSetException(string propertyName) : this(propertyName, "Property cannot be empty.") { }

        /// <summary>
        /// Initializes a new exception for the property with the specified <code>propertyName</code>.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <param name="message">The message of the exception.</param>
        public PropertyNotSetException(string propertyName, string message) : base(message) {
            PropertyName = propertyName;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets the message of the exception.
        /// </summary>
        public override string Message {
            get {
                String s = base.Message;
                if (!String.IsNullOrEmpty(PropertyName)) {
                    return s + Environment.NewLine + "Property name: " + PropertyName;
                }
                return s;
            }
        }

        #endregion

    }

}