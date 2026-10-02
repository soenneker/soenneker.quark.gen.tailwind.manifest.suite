using System.Reflection;

namespace Soenneker.Quark.Gen.Tailwind.Manifest.Suite.BuildTasks;

internal readonly record struct RuntimeMethod(MethodInfo Method, ParameterInfo[] Parameters);
