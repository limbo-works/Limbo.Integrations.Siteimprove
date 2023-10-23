using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace Limbo.Integrations.Siteimprove.Models.QualityAssurance.Spelling;

public class SiteimprovePageWithSpellingErrorsList : SiteimproveObject {

    #region Properties

    public IReadOnlyList<SiteimprovePageWithSpellingErrors> Items { get; }

    public int TotalItems { get; }

    public int TotalPages { get; }

    #endregion

    #region Constructors

    private SiteimprovePageWithSpellingErrorsList(JObject json) : base(json) {
        Items = json.GetArrayItems("items", SiteimprovePageWithSpellingErrors.Parse)!;
        TotalItems = json.GetInt32("total_items");
        TotalPages = json.GetInt32("total_pages");
    }

    #endregion

    #region Static methods

    [return: NotNullIfNotNull("json")]
    public static SiteimprovePageWithSpellingErrorsList? Parse(JObject? json) {
        return json == null ? null : new SiteimprovePageWithSpellingErrorsList(json);
    }

    #endregion

}