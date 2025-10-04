# Tasks

Noir uses [mise](https://mise.jdx.dev/) to define and run commands that make
common development tasks easier.

## Installing mise

=== "Linux/macOS"

    ```shell
    curl https://mise.run | sh
    ```

    By default, mise will be installed to `~/.local/bin` (this is simply a
    suggestion. `mise` can be installed anywhere).
    You can verify the installation by running:

    ```shell
    ~/.local/bin/mise --version
    # mise 2024.x.x
    ```

    - `~/.local/bin` does not need to be in `PATH`. mise will automatically add its own directory to `PATH`
    when [activated](#activate-mise).

    See the [official mise getting started guide](https://mise.jdx.dev/getting-started.html)
    for installation instructions for your specific linux distro.

=== "Brew"

    ```shell
    brew install mise
    ```

=== "Windows"

    ```shell title="winget"
    winget install jdx.mise
    ```

    ```shell title="scoop"
    # https://github.com/ScoopInstaller/Main/pull/6374
    scoop install mise
    ```

    ```shell title="chocolatey"
    choco install mise
    ```


## [`docs:preview`](#docspreview)

[:fontawesome-brands-docker:](https://www.docker.com/products/docker-desktop/ 'Docker Desktop')[:material-alert:](https://www.docker.com/products/docker-desktop/ 'Required tool')

Allows the previewing of the documentation site locally. To keep the generation
time low, the [git features][git-features] are disabled when previewing
documentation locally.

You can enable the git documenation features by creating a `.env.dev` file in the
root of the repository with the following contents.

```bash
MKDOCS_GIT_COMMITTERS_APIKEY=ghp_Abcdefghijklmnopqrstuvwxyz0123456789 #(1)!
GITHUB_ACTIONS=true
```

1. **Optional**, replace this with a valid GitHub Personal Authentication Token if you see rate limiting errors when building your documentation.

[git-features]: https://squidfunk.github.io/mkdocs-material/setup/adding-a-git-repository/#configuration

## [`build`](#build)

[:simple-dotnet:](https://dotnet.microsoft.com/en-us/download '.NET SDK')[:material-alert:](https://dotnet.microsoft.com/en-us/download 'Required tool')

Builds the [Runtime](./../reference/Noir/) and [Editor](./../reference/NoirEditor/)
libraries using the .NET SDK, instead of Unity. This is useful for checking code
syntax quickly or building the DLLs so they can be used for other analysis tasks.
