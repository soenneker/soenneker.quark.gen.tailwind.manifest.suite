using Microsoft.CodeAnalysis;

namespace Soenneker.Quark.Gen.Tailwind.Manifest.Suite;

/// <summary>
/// Provides the analyzer entry point for the Quark suite Tailwind manifest build package.
/// </summary>
[Generator]
public sealed class TailwindManifestSuiteGeneratorGenerator : IIncrementalGenerator
{
    /// <summary>
    /// Initializes the analyzer entry point. Suite manifest generation is performed by the package's MSBuild task.
    /// </summary>
    /// <param name="context">The incremental generator initialization context.</param>
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
    }
}
