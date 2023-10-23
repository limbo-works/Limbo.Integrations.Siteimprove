using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Integrations.Siteimprove.Models.Analytics.Behavior;

public class SiteimproveAnalyticsVisitLengthGraphItem : SiteimproveObject {

    #region Properties

    public DateTime Timestamp { get; }

    public float VisitDurationAverageInMinutes { get; }

    public TimeSpan VisitDurationAverage { get; }

    #endregion

    #region Constructors

    private SiteimproveAnalyticsVisitLengthGraphItem(JObject obj) : base(obj) {
        Timestamp = obj.GetString("timestamp", DateTime.Parse);
        VisitDurationAverageInMinutes = obj.GetFloat("visit_duration_average_in_minutes");
        VisitDurationAverage = TimeSpan.FromMinutes(VisitDurationAverageInMinutes);
    }

    #endregion

    #region Static methods

    [return: NotNullIfNotNull("obj")]
    public static SiteimproveAnalyticsVisitLengthGraphItem? Parse(JObject? obj) {
        return obj == null ? null : new SiteimproveAnalyticsVisitLengthGraphItem(obj);
    }

    #endregion

}