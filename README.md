[![](https://img.shields.io/nuget/v/soenneker.extensions.spans.generics.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.spans.generics/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.spans.generics/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.spans.generics/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.spans.generics.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.spans.generics/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.spans.generics/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.spans.generics/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Spans.Generics
Generic extension methods for rearranging and mutating writable spans without materializing another collection.

## Installation

```bash
dotnet add package Soenneker.Extensions.Spans.Generics
```

## Usage

```csharp
using Soenneker.Extensions.Spans.Generics;

Span<int> choices = [1, 2, 3, 4];
choices.SecureShuffle();
```

`SecureShuffle<T>()` uses an unbiased Fisher–Yates shuffle with `RandomNumberGenerator.GetInt32`. It changes the original span and allocates no result collection. Empty and single-element spans are left unchanged.

The shuffle is unpredictable, but it does not erase the elements or make sensitive values safe to retain in memory.
