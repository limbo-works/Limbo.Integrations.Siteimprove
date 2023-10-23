using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace Limbo.Integrations.Siteimprove.Models.Sites;

public class SiteimproveSiteItem : SiteimproveObject {

    #region Properties

    [JsonProperty("id")]
    public long Id { get; }

    [JsonProperty("site_name")]
    public string Name { get; }

    [JsonProperty("url")]
    public string Url { get; }

    [JsonProperty("pages")]
    public int Pages { get; }

    [JsonProperty("policies")]
    public int Policies { get; }

    [JsonProperty("product")]
    public string[] Product { get; }

    [JsonProperty("visits")]
    public int Visits { get; }

    #endregion

    #region Constructor

    protected SiteimproveSiteItem(JObject obj) : base(obj) {
        Id = obj.GetInt64("id");
        Name = obj.GetString("site_name")!;
        Url = obj.GetString("url")!;
        Pages = obj.GetInt32("pages");
        Policies = obj.GetInt32("policies");
        Product = obj.GetStringArray("product");
        Visits = obj.GetInt32("visits");
    }

    #endregion

    #region Static methods

    [return: NotNullIfNotNull("obj")]
    public static SiteimproveSiteItem? Parse(JObject? obj) {
        return obj == null ? null : new SiteimproveSiteItem(obj);
    }

    #endregion

}