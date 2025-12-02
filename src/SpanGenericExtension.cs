using System;
using System.Security.Cryptography;
using Soenneker.Extensions.RandomNumberGenerators;

namespace Soenneker.Extensions.Spans.Generics;

/// <summary>
/// Various helpful generic span extension methods
/// </summary>
public static class SpanGenericExtension
{
    /// <summary>
    /// Randomly shuffles the elements of the specified span using a cryptographically secure random number generator.
    /// </summary>
    /// <remarks>This method performs an in-place shuffle of the span using the Fisher–Yates algorithm and a
    /// secure random source. The original order of elements in the span will be lost after shuffling. This method is
    /// suitable for scenarios where predictable randomness must be avoided, such as shuffling sensitive data.</remarks>
    /// <typeparam name="T">The type of elements in the span to shuffle.</typeparam>
    /// <param name="span">The span whose elements will be shuffled in place.</param>
    /// <param name="rng">The cryptographically secure random number generator used to determine the shuffle order. Cannot be null.</param>
    public static void SecureShuffle<T>(this Span<T> span, RandomNumberGenerator rng)
    {
        for (int i = span.Length - 1; i > 0; i--)
        {
            int j = rng.GetInt32(i + 1);
            (span[i], span[j]) = (span[j], span[i]);
        }
    }
}