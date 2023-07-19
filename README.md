## NXOpen Templates  
This repository provides a dotnet new template for creating custom NXOpen applications using C#. It includes a basic NX Journal Template that you can use as a starting point for your own NXOpen projects.

## Prerequisites

To use this template and run the NX Journal Template, you'll need the following:

1. Siemens NX installed on your machine.
2. [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later with the ".NET desktop development" workload installed.
3. [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)
3. Basic knowledge of C# programming.
4. Some familiarity with NXOpen API. See [Getting Started with NX Open](https://docs.plm.automation.siemens.com/data_services/resources/nx/1899/nx_api/custom/en_US/gs_nx_open/NXOpen_Getting_Started.pdf) guide from Siemens.


## Getting Started

To get started, follow these steps:

1. Clone this repository to your local machine:

```bash
git clone https://github.com/alex-marinov/NXOpen.Templates.git
cd NXOpen.Templates
```

2. Build the NuGet package for the custom NXOpen templates using:

```bash
dotnet pack
```

3. Once the NuGet package is built successfully, you can install the templates on your system using dotnet new install:

```bash
dotnet new install <path_to_nuget_package_just_created>
```

## Usage

To use this NXOpen template in Visual Studio 2022, follow these steps:

1. Open Visual Studio 2022.

2. Click on "Create a new project" from the Visual Studio start page.

3. In the "Create a new project" dialog, search for "NX Journal Template" using the search bar at the top.