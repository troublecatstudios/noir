#!/usr/bin/env bash

SCRIPT_DIR=$( cd -- "$( dirname -- "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )

cd $SCRIPT_DIR

mkdir dotnet2md
curl -sSL https://github.com/isadorasophia/dotnet2md/releases/download/v0.2.7/dotnet2md-parser-v0.2.7-linux-x64.tar.gz | tar -xz --directory=dotnet2md
./dotnet2md/
