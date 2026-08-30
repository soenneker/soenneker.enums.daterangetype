[![](https://img.shields.io/nuget/v/soenneker.enums.daterangetype.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.daterangetype/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.daterangetype/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.daterangetype/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.daterangetype.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.daterangetype/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.daterangetype/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.daterangetype/actions/workflows/codeql.yml)

# Soenneker.Enums.DateRangeType

A string-backed enum-value type for selecting a predefined calendar period or a caller-supplied custom date range.

## Install

```bash
dotnet add package Soenneker.Enums.DateRangeType
```

## Usage

```csharp
using Soenneker.Enums.DateRangeType;

DateRangeType selection = DateRangeType.PreviousMonth;
string wireValue = selection.Value; // "PreviousMonth"

if (DateRangeType.TryFromValue(input, out DateRangeType? parsed))
{
    // Resolve parsed to boundaries using your application's calendar rules
}
```

Available values:

- `Today`
- `Yesterday`
- `CurrentWeek`
- `PreviousWeek`
- `CurrentMonth`
- `PreviousMonth`
- `CurrentYear`
- `PreviousYear`
- `Custom`

`System.Text.Json` serializes the type as the shown string value. `FromValue` throws for unknown input; use `TryFromValue` for request values. `FromName` and `TryFromName` are also generated for member-name lookup.

This package identifies a range selection; it does not calculate start or end timestamps. The consuming application must define its time zone, first day of the week, inclusive/exclusive boundary policy, and the explicit boundaries required by `Custom`. Capture the reference time once before resolving relative selections so a request cannot cross a calendar boundary midway through calculation.
