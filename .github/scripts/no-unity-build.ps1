Set-Location $PSScriptRoot

Set-Location ./../build/
dotnet build ./Noir.csproj
dotnet build ./NoirEditor.csproj

Set-Location ../../
