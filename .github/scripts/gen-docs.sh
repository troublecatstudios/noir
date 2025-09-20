#!/usr/bin/env bash

SCRIPT_DIR=$( cd -- "$( dirname -- "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )

cd $SCRIPT_DIR

cd ./../build
dotnet build ./Noir.csproj
dotnet build ./NoirEditor.csproj

cd $SCRIPT_DIR

dotnet ./dotnet2md/dotnet2md.dll ./../../.build/bin/NoirEditor/Release/netcoreapp3.1/ ./../../docs/reference/ Noir NoirEditor
