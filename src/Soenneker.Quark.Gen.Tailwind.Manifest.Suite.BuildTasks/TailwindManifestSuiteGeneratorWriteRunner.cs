using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Soenneker.Quark.Gen.Tailwind.Manifest.BuildTasks.Abstract;
using Soenneker.Quark.Gen.Tailwind.Manifest.Suite.BuildTasks.Abstract;

namespace Soenneker.Quark.Gen.Tailwind.Manifest.Suite.BuildTasks;

///<inheritdoc cref="Abstract.ITailwindManifestSuiteGeneratorWriteRunner"/>
public sealed class TailwindManifestSuiteGeneratorWriteRunner : ITailwindManifestSuiteGeneratorWriteRunner
{
    private readonly IQuarkTailwindManifestGenerator _runner;

    public TailwindManifestSuiteGeneratorWriteRunner(IQuarkTailwindManifestGenerator runner)
    {
        _runner = runner;
    }

    public ValueTask<int> Run(string[] args, CancellationToken cancellationToken)
    {
        string[] suiteArgs = BuildSuiteArgs(args);
        return _runner.Run(suiteArgs, cancellationToken);
    }

    private static string[] BuildSuiteArgs(string[] args)
    {
        var result = new List<string>(args.Length + 2);

        for (var i = 0; i < args.Length; i++)
        {
            if (string.Equals(args[i], "--mode", StringComparison.OrdinalIgnoreCase))
            {
                if (i + 1 < args.Length)
                    i++;

                continue;
            }

            result.Add(args[i]);
        }

        result.Add("--mode");
        result.Add("suite");

        return result.ToArray();
    }
}
