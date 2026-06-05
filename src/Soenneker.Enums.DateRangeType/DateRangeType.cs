using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.DateRangeType;

/// <summary>
/// An enumerator for describing common date ranges
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class DateRangeType
{
    /// <summary>
    /// The today.
    /// </summary>
    public static readonly DateRangeType Today = new(nameof(Today));

    /// <summary>
    /// The yesterday.
    /// </summary>
    public static readonly DateRangeType Yesterday = new(nameof(Yesterday));

    /// <summary>
    /// The current week.
    /// </summary>
    public static readonly DateRangeType CurrentWeek = new(nameof(CurrentWeek));

    /// <summary>
    /// The previous week.
    /// </summary>
    public static readonly DateRangeType PreviousWeek = new(nameof(PreviousWeek));

    /// <summary>
    /// The current month.
    /// </summary>
    public static readonly DateRangeType CurrentMonth = new(nameof(CurrentMonth));

    /// <summary>
    /// The previous month.
    /// </summary>
    public static readonly DateRangeType PreviousMonth = new(nameof(PreviousMonth));

    /// <summary>
    /// The current year.
    /// </summary>
    public static readonly DateRangeType CurrentYear = new(nameof(CurrentYear));

    /// <summary>
    /// The previous year.
    /// </summary>
    public static readonly DateRangeType PreviousYear = new(nameof(PreviousYear));

    /// <summary>
    /// The custom.
    /// </summary>
    public static readonly DateRangeType Custom = new(nameof(Custom));
}