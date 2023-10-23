using System;

namespace Limbo.Integrations.Siteimprove.Options.Analytics;

/// <summary>
/// Class representing a period.
/// </summary>
public class SiteimprovePeriod {

    private readonly string _value;

    #region Properties

    public static readonly SiteimprovePeriod Now = new("now");

    public static readonly SiteimprovePeriod Today = new("today");

    public static readonly SiteimprovePeriod Yesterday = new("yesterday");

    public static readonly SiteimprovePeriod LastSevenDays = new("last_seven_days");

    public static readonly SiteimprovePeriod LastWeek = new("last_week");

    public static readonly SiteimprovePeriod LastMonth = new("last_month");

    public static readonly SiteimprovePeriod ThisMonth = new("this_month");

    public static readonly SiteimprovePeriod ThisYear = new("this_year");

    #endregion

    #region Constructors

    public SiteimprovePeriod(string alias) {
        _value = alias;
    }

    public SiteimprovePeriod(DateTime date) {
        _value = $"{date:yyyyMMdd}";
    }

    public SiteimprovePeriod(DateTime from, DateTime to) {
        _value = $"{from:yyyyMMdd}_{to:yyyyMMdd}";
    }

    #endregion

    #region Member methods

    public override string ToString() {
        return _value;
    }

    #endregion

}