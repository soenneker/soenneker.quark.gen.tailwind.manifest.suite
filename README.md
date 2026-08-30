[![](https://img.shields.io/nuget/v/soenneker.quark.gen.tailwind.manifest.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.gen.tailwind.manifest.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.gen.tailwind.manifest.suite/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.gen.tailwind.manifest.suite/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.gen.tailwind.manifest.suite/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.gen.tailwind.manifest.suite/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.gen.tailwind.manifest.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.gen.tailwind.manifest.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.gen.tailwind.manifest.suite/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.gen.tailwind.manifest.suite/actions/workflows/codeql.yml)

# Soenneker.Quark.Gen.Tailwind.Manifest.Suite

Generates the Tailwind class manifest distributed with `Soenneker.Quark.Suite`.

This package is for building the Quark component suite or another suite-compatible component library. Application projects should use `Soenneker.Quark.Gen.Tailwind.Manifest` instead.

## Install

```bash
dotnet add package Soenneker.Quark.Gen.Tailwind.Manifest.Suite
```

## Usage

Install the package in the component-library project and build normally:

```bash
dotnet build
```

The build writes `tailwind/quark-suite-tailwind-manifest.txt`. Package that file with the component library so consuming applications can include the library’s generated, literal, variant, and responsive utility classes in their Tailwind build.

The manifest is replaced on subsequent builds and should not be edited manually. Classes assembled exclusively from runtime data cannot be discovered and must be supplied explicitly by the library.

## Configuration

Generation is enabled by default. Disable it or redirect its output with MSBuild properties:

```xml
<PropertyGroup>
  <TailwindManifestSuiteGeneratorBuildEnabled>false</TailwindManifestSuiteGeneratorBuildEnabled>
  <TailwindManifestSuiteOutput>$(IntermediateOutputPath)quark-suite-tailwind-manifest.txt</TailwindManifestSuiteOutput>
</PropertyGroup>
```

Set only the property you need. If output is redirected, ensure the resulting manifest is still included in the component-library package.
