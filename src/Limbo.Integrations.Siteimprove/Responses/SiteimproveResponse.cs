using System;
using System.Net;
using Limbo.Integrations.Siteimprove.Exceptions;
using Limbo.Integrations.Siteimprove.Models;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Responses;

/// <summary>
/// Class representing a response from the Siteimprove API.
/// </summary>
public class SiteimproveResponse : HttpResponseBase {

    #region Properties

    /// <summary>
    /// The Siteimprove API enforces rate limiting. See the API documentation for further information.
    /// </summary>
    /// <see cref="http://developer.siteimprove.com/v1/api-guidelines/" />
    public SiteimproveRateLimiting RateLimiting { get; }

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance based on the specified <paramref name="response"/>.
    /// </summary>
    /// <param name="response">The underlying raw response the instance should be based on.</param>
    protected SiteimproveResponse(IHttpResponse response) : base(response) {

        // Throw an exception if the statuis code is not 200 OK
        if (response.StatusCode != HttpStatusCode.OK) throw new SiteimproveHttpException(response);

        RateLimiting = new SiteimproveRateLimiting(response);

    }

    #endregion

    #region Member methods

    /// <summary>
    /// Parses the specified <paramref name="json"/> string into an instance of <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type to be returned.</typeparam>
    /// <param name="json">The JSON string to be parsed.</param>
    /// <param name="callback">A callback function/method used for converting an instance of <see cref="JObject"/> into an instance of <typeparamref name="T"/>.</param>
    /// <returns>An instance of <typeparamref name="T"/> parsed from the specified json string.</returns>
    public new T ParseJsonObject<T>(string json, Func<JObject, T?> callback) {
        return HttpResponseBase.ParseJsonObject(json, callback)!;
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
    public T Body { get; protected set; } = default!;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance based on the specified <paramref name="response"/>.
    /// </summary>
    /// <param name="response">The underlying raw response the instance should be based on.</param>
    protected SiteimproveResponse(IHttpResponse response) : base(response) { }

    #endregion

}