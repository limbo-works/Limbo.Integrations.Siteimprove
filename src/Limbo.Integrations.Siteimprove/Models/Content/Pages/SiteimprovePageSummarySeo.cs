﻿using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace Limbo.Integrations.Siteimprove.Models.Content.Pages;

public class SiteimprovePageSummarySeo : SiteimproveObject {

    #region Properties

    public int Errors { get; }

    public int NeedsReview { get; }

    public int Warnings { get; }

    #endregion

    #region Constructors

    private SiteimprovePageSummarySeo(JObject obj) : base(obj) {
        Errors = obj.GetInt32("errors");
        NeedsReview = obj.GetInt32("needs_review");
        Warnings = obj.GetInt32("warnings");
    }

    #endregion

    #region Static methods

    [return: NotNullIfNotNull("obj")]
    public static SiteimprovePageSummarySeo? Parse(JObject? obj) {
        return obj == null ? null : new SiteimprovePageSummarySeo(obj);
    }

    #endregion

}