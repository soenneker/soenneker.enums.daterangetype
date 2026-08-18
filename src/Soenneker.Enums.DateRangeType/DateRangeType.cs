using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.DateRangeType;

/// <summary>
/// Identifies a predefined calendar range or a caller-supplied custom date range.
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class DateRangeType
{
    /// <summary>
    /// The current calendar day.
    /// </summary>
    public static readonly DateRangeType Today = new(nameof(Today));

    /// <summary>
    /// The calendar day immediately before today.
    /// </summary>
    public static readonly DateRangeType Yesterday = new(nameof(Yesterday));

    /// <summary>
    /// The current calendar week.
    /// </summary>
    public static readonly DateRangeType CurrentWeek = new(nameof(CurrentWeek));

    /// <summary>
    /// The calendar week immediately before the current week.
    /// </summary>
    public static readonly DateRangeType PreviousWeek = new(nameof(PreviousWeek));

    /// <summary>
    /// The current calendar month.
    /// </summary>
    public static readonly DateRangeType CurrentMonth = new(nameof(CurrentMonth));

    /// <summary>
    /// The calendar month immediately before the current month.
    /// </summary>
    public static readonly DateRangeType PreviousMonth = new(nameof(PreviousMonth));

    /// <summary>
    /// The current calendar year.
    /// </summary>
    public static readonly DateRangeType CurrentYear = new(nameof(CurrentYear));

    /// <summary>
    /// The calendar year immediately before the current year.
    /// </summary>
    public static readonly DateRangeType PreviousYear = new(nameof(PreviousYear));

    /// <summary>
    /// A date range whose boundaries are supplied explicitly by the caller.
    /// </summary>
    public static readonly DateRangeType Custom = new(nameof(Custom));
}
