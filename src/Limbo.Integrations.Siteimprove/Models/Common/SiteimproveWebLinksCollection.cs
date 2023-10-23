using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace Limbo.Integrations.Siteimprove.Models.Common;

public class SiteimproveWebLinksCollection : SiteimproveLinksCollection {

    #region Properties

    [JsonProperty("page_report")]
    public string PageReport { get; }

    #endregion

    #region Constructor

    private SiteimproveWebLinksCollection(JObject obj) : base(obj) {
        PageReport = obj.GetString("page_report")!;
    }

    #endregion

    #region Static methods

    [return: NotNullIfNotNull("obj")]
    public new static SiteimproveWebLinksCollection? Parse(JObject? obj) {
        return obj == null ? null : new SiteimproveWebLinksCollection(obj);
    }

    #endregion

}