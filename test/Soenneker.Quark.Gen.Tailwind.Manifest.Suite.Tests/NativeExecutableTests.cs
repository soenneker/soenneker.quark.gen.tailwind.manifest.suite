using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Soenneker.Quark.Gen.Tailwind.Manifest.Suite.Tests;

public sealed class NativeExecutableTests
{
    [Test]
    public async Task Native_executable_generates_expected_output_deterministically()
    {
        // Native matrix jobs supply the published executable; ordinary managed test runs do not.
        string? executable = Environment.GetEnvironmentVariable("QUARK_NATIVE_TOOL");
        if (string.IsNullOrEmpty(executable)) return;
        string directory = Path.Combine(Path.GetTempPath(), "quark native " + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(directory);
        try
        {
            await File.WriteAllTextAsync(Path.Combine(directory, "Usage.cs"), "var a = Quark.TextSize.Sm; var b = Quark.Rounded.Top.Xl; var c = Quark.Top.Token(\"[calc(var(--header-height)+1rem)]\"); var d = Quark.TextSize.OnFocusVisible.Sm;");
            string output = Path.Combine(directory, "manifest.txt");
            string[] arguments = ["--projectDir", directory, "--manifestOutput", output];
            string[] expectedValues = ["text-sm", "rounded-t-xl", "top-[calc(var(--header-height)+1rem)]", "focus-visible:text-sm"];
            async Task Run()
            {
                var start = new ProcessStartInfo(executable) { UseShellExecute = false };
                foreach (string argument in arguments) start.ArgumentList.Add(argument);
                using var process = Process.Start(start) ?? throw new Exception("Native tool could not start.");
                await process.WaitForExitAsync();
                if (process.ExitCode != 0) throw new Exception("Native tool failed: " + process.ExitCode);
            }
            await Run();
            string content = await File.ReadAllTextAsync(output);
            foreach (string expected in expectedValues)
                if (!content.Contains(expected, StringComparison.Ordinal)) throw new Exception("Native output is missing " + expected);
            await Run();
            if (await File.ReadAllTextAsync(output) != content) throw new Exception("Native output changed with identical inputs.");
        }
        finally { Directory.Delete(directory, recursive: true); }
    }
}
