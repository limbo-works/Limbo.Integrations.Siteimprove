using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace Limbo.Integrations.Siteimprove.Models.QualityAssurance.BrokenLinks;

public class SiteimprovePageWithBrokenLinksList : SiteimproveObject {

    #region Properties

    public IReadOnlyList<SiteimprovePageWithBrokenLinks> Items { get; }

    public int TotalItems { get; }

    public int TotalPages { get; }

    #endregion

    #region Constructors

    private SiteimprovePageWithBrokenLinksList(JObject json) : base(json) {
        Items = json.GetArrayItems("items", SiteimprovePageWithBrokenLinks.Parse)!;
        TotalItems = json.GetInt32("total_items");
        TotalPages = json.GetInt32("total_pages");
    }

    #endregion

    #region Static methods

    [return: NotNullIfNotNull("obj")]
    public static SiteimprovePageWithBrokenLinksList? Parse(JObject? json) {
        return json == null ? null : new SiteimprovePageWithBrokenLinksList(json);
    }

    #endregion

}