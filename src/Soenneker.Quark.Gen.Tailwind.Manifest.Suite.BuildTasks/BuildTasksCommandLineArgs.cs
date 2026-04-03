namespace Soenneker.Quark.Gen.Tailwind.Manifest.Suite.BuildTasks;

public sealed class BuildTasksCommandLineArgs
{
    public string[] Args { get; }

    public BuildTasksCommandLineArgs(string[] args)
    {
        Args = args;
    }
}
