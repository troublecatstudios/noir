
Set-Location $PSScriptRoot

Set-Location ./../build/
dotnet build ./Noir.csproj
dotnet build ./NoirEditor.csproj

Set-Location $PSScriptRoot

dotnet ./dotnet2md/Parser.dll ./../../../.build/bin/NoirEditor/Release/netcoreapp3.1/ ./../../../docs/reference/ Noir NoirEditor

Copy-Item ./../../package/CHANGELOG.md ./../../docs/getting_started/changelog.md
Copy-Item './../../package/Third Party Notices.md' ./../../docs/getting_started/third_party_notices.md
Copy-Item ./../../package/LICENSE.md ./../../docs/getting_started/license.md

Set-Location ../../
