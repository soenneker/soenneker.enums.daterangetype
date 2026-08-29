[![](https://img.shields.io/nuget/v/soenneker.enums.daterangetype.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.daterangetype/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.daterangetype/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.daterangetype/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.daterangetype.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.daterangetype/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.daterangetype/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.daterangetype/actions/workflows/codeql.yml)

# Soenneker.Enums.DateRangeType

Identifies a predefined calendar range or a caller-supplied custom date range.

## Install

```bash
dotnet add package Soenneker.Enums.DateRangeType
```

## What you get

- `DateRangeType` — Identifies a predefined calendar range or a caller-supplied custom date range.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `DateRangeType.Yesterday` | The calendar day immediately before today. | The calendar day immediately before today. |
| `DateRangeType.PreviousWeek` | The calendar week immediately before the current week. | The calendar week immediately before the current week. |
| `DateRangeType.PreviousMonth` | The calendar month immediately before the current month. | The calendar month immediately before the current month. |
| `DateRangeType.PreviousYear` | The calendar year immediately before the current year. | The calendar year immediately before the current year. |
| `DateRangeType.Custom` | A date range whose boundaries are supplied explicitly by the caller. | A date range whose boundaries are supplied explicitly by the caller. |
