using Microsoft.Extensions.DependencyInjection;
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
        services.AddScoped<ITailwindManifestSuiteGeneratorWriteRunner, TailwindManifestSuiteGeneratorWriteRunner>();
        services.AddHostedService<ConsoleHostedService>();
    }
}
