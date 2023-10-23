using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using System.Diagnostics.CodeAnalysis;

namespace Limbo.Integrations.Siteimprove.Models.Content.Pages;

public class SiteimprovePageSummaryPage : SiteimproveObject {

    #region Properties

    /// <summary>
    /// Gets whether the page can be checked.
    /// </summary>
    public bool CheckAllowed { get; }

    /// <summary>
    /// Gets whether page checking is currently paused.
    /// </summary>
    public bool CheckPaused { get; }

    /// <summary>
    /// Gets whether the page is scheduled for checking.
    /// </summary>
    public bool CheckingNow { get; }

    /// <summary>
    /// Gets a timestamp for when the page was first seen.
    /// </summary>
    public EssentialsTime FirstSeen { get; }

    /// <summary>
    /// Gets a timestamp for when a change was last detected on the page.
    /// </summary>
    public EssentialsTime LastChanged { get; }

    /// <summary>
    /// Gets a timestamp for when the page was last seen.
    /// </summary>
    public EssentialsTime LastSeen { get; }

    #endregion

    #region Constructors

    private SiteimprovePageSummaryPage(JObject obj) : base(obj) {
        CheckAllowed = obj.GetBoolean("check_allowed");
        CheckPaused = obj.GetBoolean("check_paused");
        CheckingNow = obj.GetBoolean("checking_now");
        FirstSeen = obj.GetString("first_seen", EssentialsTime.Parse)!;
        LastChanged = obj.GetString("last_changed", EssentialsTime.Parse)!;
        LastSeen = obj.GetString("last_seen", EssentialsTime.Parse)!;
    }

    #endregion

    #region Static methods

    [return: NotNullIfNotNull("obj")]
    public static SiteimprovePageSummaryPage? Parse(JObject? obj) {
        return obj == null ? null : new SiteimprovePageSummaryPage(obj);
    }

    #endregion

}