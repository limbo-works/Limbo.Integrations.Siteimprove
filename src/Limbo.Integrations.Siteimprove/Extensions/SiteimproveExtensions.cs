using System;
using Limbo.Integrations.Siteimprove.Options.Analytics;

namespace Limbo.Integrations.Siteimprove.Extensions;

public static class SiteimproveExtensions {

    /// <summary>
    /// Sets the <see cref="SiteimproveAnalyticsOptionsBase.Period"/> property based on the specified <paramref name="day"/>.
    /// </summary>
    /// <param name="options">An instance of <see cref="SiteimproveAnalyticsOptionsBase"/>.</param>
    /// <param name="day">The day.</param>
    /// <returns>Returns the options instance for method chaining.</returns>
    public static T SetPeriod<T>(this T options, DateTime day) where T : SiteimproveAnalyticsOptionsBase {
        options.Period = new SiteimprovePeriod(day);
        return options;
    }

    /// <summary>
    /// Sets the <see cref="SiteimproveAnalyticsOptionsBase.Period"/> property based on the specified <paramref name="from"/> and <paramref name="to"/>.
    /// </summary>
    /// <param name="options">An instance of <see cref="SiteimproveAnalyticsOptionsBase"/>.</param>
    /// <param name="from">The start date of the period.</param>
    /// <param name="to">The end date of the period.</param>
    /// <returns>Returns the options instance for method chaining.</returns>
    public static T SetPeriod<T>(this T options, DateTime from, DateTime to) where T : SiteimproveAnalyticsOptionsBase {
        options.Period = new SiteimprovePeriod(from, to);
        return options;
    }

}