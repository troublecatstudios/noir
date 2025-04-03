#!/usr/bin/env bash

SCRIPT_DIR=$( cd -- "$( dirname -- "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )

# change to repo root
cd ../../

# clean the package samples
rm -rf package/Samples~/
mkdir package/Samples~/

# copy the samples from the project to the package
cp -r unity-project/Assets/Samples/. package/Samples~/
