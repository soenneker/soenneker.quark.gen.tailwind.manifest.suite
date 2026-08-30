using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Quark.Gen.Tailwind.Manifest.Suite.BuildTasks.Abstract;

/// <summary>
/// Generates the Tailwind source manifest distributed by a Quark component suite.
/// </summary>
public interface ITailwindManifestSuiteGeneratorWriteRunner
{
    /// <summary>
    /// Generates the suite manifest using the supplied build-task arguments.
    /// </summary>
    /// <param name="args">Command-line arguments passed to the application.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>The process exit code: zero on success; otherwise nonzero.</returns>
    ValueTask<int> Run(string[] args, CancellationToken cancellationToken);
}
