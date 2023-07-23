![GitHub Workflow Status (with event)](https://img.shields.io/github/actions/workflow/status/alex-marinov/NXOpen.Templates/dotnet.yml) ![Nuget](https://img.shields.io/nuget/v/NXOpen.Templates)

## NXOpen Templates

This repository provides a dotnet new template for creating custom NXOpen applications using C#. It includes a basic NX Journal Template that you can use as a starting point for your own NXOpen projects.

## Prerequisites

To use this template and run the NX Journal Template, you'll need the following:

1. Siemens NX installed on your machine.
2. [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later with the ".NET desktop development" workload installed. You can also use [Visual Studio Code](https://code.visualstudio.com) with [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) and [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) extensions.
3. [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)
4. Basic knowledge of C# programming.
5. Some familiarity with NXOpen API. See [Getting Started with NX Open](https://docs.plm.automation.siemens.com/data_services/resources/nx/1899/nx_api/custom/en_US/gs_nx_open/NXOpen_Getting_Started.pdf) guide from Siemens.

## Getting Started

To get started, follow these steps:

1. Run following command to install the project templates:

```bash
dotnet new install NXOpen.Templates
```

## Usage

### Using the CLI

1. Run `dotnet new nxjournal`

### Using Visual Studio

1. Select 'NX Journal Template' when you create a new project
