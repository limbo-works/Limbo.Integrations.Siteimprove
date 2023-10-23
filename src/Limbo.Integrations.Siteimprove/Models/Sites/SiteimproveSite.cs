using Newtonsoft.Json.Linq;
using System.Diagnostics.CodeAnalysis;

namespace Limbo.Integrations.Siteimprove.Models.Sites;

public class SiteimproveSite : SiteimproveSiteItem {

    #region Constructors

    protected SiteimproveSite(JObject obj) : base(obj) { }

    #endregion

    #region Static methods

    [return: NotNullIfNotNull("obj")]
    public new static SiteimproveSite? Parse(JObject? obj) {
        return obj == null ? null : new SiteimproveSite(obj);
    }

    #endregion

}