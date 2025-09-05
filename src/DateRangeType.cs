using Intellenum;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.DateRangeType;

/// <summary>
/// An enumerator for describing common date ranges
/// </summary>
[PublicOpenApiObject]
[Intellenum<string>]
public partial class DateRangeType
{
    public static readonly DateRangeType Today = new(nameof(Today));

    public static readonly DateRangeType Yesterday = new(nameof(Yesterday));

    public static readonly DateRangeType CurrentWeek = new(nameof(CurrentWeek));

    public static readonly DateRangeType PreviousWeek = new(nameof(PreviousWeek));

    public static readonly DateRangeType CurrentMonth = new(nameof(CurrentMonth));

    public static readonly DateRangeType PreviousMonth = new(nameof(PreviousMonth));

    public static readonly DateRangeType CurrentYear = new(nameof(CurrentYear));

    public static readonly DateRangeType PreviousYear = new(nameof(PreviousYear));

    public static readonly DateRangeType Custom = new(nameof(Custom));
}