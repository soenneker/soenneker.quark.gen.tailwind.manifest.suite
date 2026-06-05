using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

namespace Soenneker.Quark.Gen.Tailwind.Manifest.Suite;

/// <summary>
/// Represents the tailwind manifest suite generator generator.
/// </summary>
[Generator]
public sealed class TailwindManifestSuiteGeneratorGenerator : IIncrementalGenerator
{
    /// <summary>
    /// Executes the initialize operation.
    /// </summary>
    /// <param name="context">The context.</param>
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
    }
}
