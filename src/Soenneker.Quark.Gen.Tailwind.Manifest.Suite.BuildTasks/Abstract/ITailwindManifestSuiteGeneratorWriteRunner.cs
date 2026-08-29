using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Quark.Gen.Tailwind.Manifest.Suite.BuildTasks.Abstract;

/// <summary>
/// Defines the tailwind manifest suite generator write runner contract.
/// </summary>
public interface ITailwindManifestSuiteGeneratorWriteRunner
{
    /// <summary>
    /// Runs tailwind Manifest Suite Generator Write Runner for the Tailwind Manifest Suite Generator Write Runner.
    /// </summary>
    /// <param name="args">Command-line arguments passed to the application.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested value.</returns>
    ValueTask<int> Run(string[] args, CancellationToken cancellationToken);
}
