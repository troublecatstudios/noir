
Set-Location $PSScriptRoot
Set-Location ../../

docker build -t mkdocs:local -f ./.github/scripts/mkdocs.dockerfile .
docker run -p 8000:8000 mkdocs:local
