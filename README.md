# Calcu-consoleApp.
NET Samples
The code in this repository represents programs that demonstrate Math operations such as addition, multiplication.

Building a sample for Use code coverage for unit testing
Build any .NET Core sample using the .NET Core CLI, which is installed with the .NET Core SDK. Then run these commands from the CLI in the directory of any sample:

To build and run your sample 

Go to the sample folder and build to check for errors:
dotnet build

dotnet build
another way to build project

dotnet msbuild
Run your sample:

dotnet run
another way to run project

dotnet run --project .\CalcConsoleApp\CalcConsoleApp.csproj
Code coverage tooling
There are two types of code coverage tools:

DataCollectors: DataCollectors monitor test execution and collect information about test runs. They report the collected information in various output formats, such as XML and JSON. For more information, see your first DataCollector.

Report generators: Use data collected from test runs to generate reports, often as styled HTML.

Run Tests
dotnet test
Usage

Coverlet is integrated into the Visual Studio Test Platform as a data collector. To get coverage simply run the following command:

dotnet test --collect:"XPlat Code Coverage"
Console code coverage report
Generate console code coverage report with coverlet console

Installation - coverlet.console

dotnet tool install -g coverlet.console
Usage - coverlet.console

coverlet ./CalcConsoleApp.Tests/bin/Debug/net6.0/CalcConsoleApp.Tests.dll --target "dotnet" --targetargs "test --no-build"
Generate reports
Installation - dotnet-reportgenerator-globaltool

dotnet tool install -g dotnet-reportgenerator-globaltool
Usage - Generating a .htm report using ReportGenerator

reportgenerator -reports:"CalcConsoleApp.Tests\TestResults\adb8ac0b-c22f-4932-8a0b-e57685f74e95\coverage.cobertura.xml" -targetdir:"coverageresults"
another way

reportgenerator -reports:"CalcConsoleApp.Tests\TestResults\*\coverage.cobertura.xml" -targetdir:"coverageresults"
dotnet tools
How to check what are tools installed on Server/Local

dotnet tool search format
