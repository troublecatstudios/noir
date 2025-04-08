
Set-Location $PSScriptRoot
mkdir dotnet2md
Invoke-WebRequest https://github.com/isadorasophia/dotnet2md/releases/download/v0.2.7/dotnet2md-parser-v0.2.7-win-x64.zip -OutFile parser.zip
Expand-Archive parser.zip -DestinationPath dotnet2md
Remove-Item parser.zip

./dotnet2md/Parser.exe
