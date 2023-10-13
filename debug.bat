@echo off

dotnet build src/Limbo.Integrations.Siteimprove --configuration Debug /t:rebuild /t:pack -p:PackageOutputPath=c:/nuget