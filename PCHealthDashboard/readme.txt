===================================================================
1. Prerequisites
===================================================================
.NET SDK 6/7/8              MUST BE INSTALLED
Visual Studio Code          MUST BE INSTALLED
C# Extension for VS CODE    MUST BE INSTALLED FROM THE VS CODE EXTENSION TAB
WINDOWS O.S.                REQUIRED FOR WPF 
===================================================================
2. Create the Project Manually
===================================================================
This is normally easier if done in Visual Studio but VSCODE works and is free.
On the cmd line

        -> dotnet new wpf -n PCHealthDashboard
           cd PCHealthDashboard
           code .

This should create a WPF project called PCHealthDashboard and open it in VSCODE
===================================================================
3. Project Structure
===================================================================
PCHealthDashboard/
|-----------------App.xaml
|-----------------App.xaml.cs
|-----------------MainWindow.xaml
|-----------------MainWindow.xaml.cs
|-----------------PCHealthDashboard.csproj

Now manually create the folder:

|------ Services/
|    |----------SystemMonitorService.cs
===================================================================
4. Add the reference to Microsoft.VisualBasic
===================================================================
In the .csproj file paste:

<Project Sdk="Microsoft.NET.Sdk.WindowsDesktop">

  <PropertyGroup>
    <OutputType>WinExe</OutputType>
    <TargetFramework>net6.0-windows</TargetFramework>
    <UseWPF>true</UseWPF>
  </PropertyGroup>

  <ItemGroup>
    <Reference Include="Microsoft.VisualBasic" />
  </ItemGroup>

</Project>

Now on the command line write: dotnet restore

===================================================================
5. Build and run
===================================================================

Now lastly on the cmd line: dotnet run
===================================================================

To make things easier in VS CODE
Enable OmniShare (C# IntelliSense)
Install the NuGet Package Manager GUI
Add a launch.json if you want F5 debug support.
