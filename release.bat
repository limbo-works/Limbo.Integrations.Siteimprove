@echo off

dotnet build src/Limbo.Integrations.Siteimprove --configuration Release /t:rebuild /t:pack -p:PackageOutputPath=../../releases/nuget