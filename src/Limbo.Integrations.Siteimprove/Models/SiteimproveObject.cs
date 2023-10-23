using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Limbo.Integrations.Siteimprove.Models;

/// <summary>
/// Class representing a basic object from the Siteimprove API derived from an instance of <see cref="JObject"/>.
/// </summary>
public class SiteimproveObject {

    #region Properties

    /// <summary>
    /// Gets a reference to the internal <see cref="JObject"/> the object was created from.
    /// </summary>
    [JsonIgnore]
    public JObject JObject { get; }

    #endregion

    #region Constructor

    /// <summary>
    /// Initializes a new instance from the specified <paramref name="obj"/>.
    /// </summary>
    /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
    protected SiteimproveObject(JObject obj) {
        JObject = obj;
    }

    #endregion

}