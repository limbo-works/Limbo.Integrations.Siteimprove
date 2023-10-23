using System.Net;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Exceptions;

/// <summary>
/// Class representing an exception/error returned by the Sitemprove API.
/// </summary>
public class SiteimproveHttpException : SiteimproveException {

    /// <summary>
    /// Gets a reference to the underlying <see cref="IHttpResponse"/>.
    /// </summary>
    public IHttpResponse Response { get; }

    /// <summary>
    /// Gets the HTTP status code returned by the Sitemprove API.
    /// </summary>
    public HttpStatusCode StatusCode { get; }

    /// <summary>
    /// Initializes a new exception based on the specified <paramref name="response"/>.
    /// </summary>
    /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the raw response.</param>
    public SiteimproveHttpException(IHttpResponse response) : base($"Invalid response received from the Siteimprove API (status: {(int) response.StatusCode})") {
        Response = response;
        StatusCode = response.StatusCode;
    }

}