using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Quark.Gen.Tailwind.Manifest.BuildTasks;
using Soenneker.Quark.Gen.Tailwind.Manifest.BuildTasks.Abstract;
using Soenneker.Quark.Gen.Tailwind.Manifest.Suite.BuildTasks.Abstract;
using Soenneker.Utils.Directory.Registrars;
using Soenneker.Utils.File.Registrars;

namespace Soenneker.Quark.Gen.Tailwind.Manifest.Suite.BuildTasks;

public static class Startup
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddFileUtilAsScoped()
                .AddDirectoryUtilAsScoped();
        services.TryAddScoped<IQuarkTailwindManifestGenerator, QuarkTailwindManifestGenerator>();
        services.TryAddScoped<ITailwindManifestSuiteGeneratorWriteRunner, TailwindManifestSuiteGeneratorWriteRunner>();
        services.AddHostedService<ConsoleHostedService>();
    }
}
