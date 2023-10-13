using System;

namespace Limbo.Integrations.Siteimprove.Exceptions;

/// <summary>
/// Class representing a basic Siteimprove exception.
/// </summary>
public class SiteimproveException : Exception {

    /// <summary>
    /// Initializes a new exception with the specified <paramref name="message"/>.
    /// </summary>
    /// <param name="message">The message of the exception.</param>
    public SiteimproveException(string message) : base(message) { }

}