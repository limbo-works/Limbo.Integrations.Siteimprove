using System.Net;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Exceptions;

/// <summary>
/// Class representing an exception/error returned by the Sitemprove API.
/// </summary>
public class SiteimproveApiException : SiteimproveException {

    /// <summary>
    /// Gets a reference to the underlying <see cref="IHttpResponse"/>.
    /// </summary>
    public IHttpResponse Response { get; }

    /// <summary>
    /// Gets the status code of the underlying HTTP request.
    /// </summary>
    public HttpStatusCode StatusCode { get; }

    /// <summary>
    /// Gets the type of the error.
    /// </summary>
    public string Type { get; }

    /// <summary>
    /// Initializes a new exception based on the specified <paramref name="response"/>.
    /// </summary>
    /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the raw response.</param>
    /// <param name="message">The error message.</param>
    /// <param name="type">The error type.</param>
    public SiteimproveApiException(IHttpResponse response, string message, string type) : base(message) {
        Response = response;
        StatusCode = response.StatusCode;
        Type = type;
    }

}