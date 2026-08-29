[![](https://img.shields.io/nuget/v/soenneker.extensions.spans.generics.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.spans.generics/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.spans.generics/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.spans.generics/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.spans.generics.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.spans.generics/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.spans.generics/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.spans.generics/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Spans.Generics
Various helpful generic span extension methods.

## Installation

```bash
dotnet add package Soenneker.Extensions.Spans.Generics
```

## Quick start

```csharp
using Soenneker.Extensions.Spans.Generics;

// Given an existing Span<T> named span:
span.SecureShuffle();
```

## Common operations

- `SecureShuffle()` - Randomly shuffles the elements of the specified span using a cryptographically secure random number generator. This method performs an in-place shuffle of the span using the Fisher–Yates algorithm and a secure random source.
