using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Quark.Gen.Tailwind.Manifest.Suite.BuildTasks.Abstract;

public interface ITailwindManifestSuiteGeneratorWriteRunner
{
    ValueTask<int> Run(string[] args, CancellationToken cancellationToken);
}
