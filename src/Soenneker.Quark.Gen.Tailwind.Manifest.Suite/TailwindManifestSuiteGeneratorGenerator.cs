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
    /// Initializes the Tailwind Manifest Suite Generator Generator so it is ready for use.
    /// </summary>
    /// <param name="context">HTTP context containing the Authorization header.</param>
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
    }
}
