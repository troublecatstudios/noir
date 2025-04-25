# Developing

## Setup

In order to work on the Noir source code you'll need the following software installed on your computer.

- [Unity](https://unity.com/) 2021.3.22f1 or greater
- [Visual Studio Code](https://code.visualstudio.com/) or [Rider](https://www.jetbrains.com/rider/)
- [mise en place](https://mise.jdx.dev/) :material-checkbox-marked-circle-auto-outline:{ title="Used for developer tasks" }
- [Docker desktop](https://www.docker.com/products/docker-desktop/) :material-checkbox-marked-circle-auto-outline:{ title="Used for developer tasks" }
- [.NET SDK](https://dotnet.microsoft.com/en-us/download) :material-checkbox-marked-circle-auto-outline:{ title="Used for developer tasks" }

## Development process overview

Development on Noir uses a mainline branching scheme with release tagging. All development occurs off of the `develop` branch. The `stable` branch is used as a merge point to generate new release tags.

The diagram below shows how the git workflow looks as a new feature is started, worked on and then merged into `develop` with a follow-up minor version release.

```mermaid
%%{init: { 'gitGraph': {'mainBranchName': 'stable'}} }%%
gitGraph
    commit tag:"v0.0.1"
    branch develop
    checkout develop
    commit
    commit
    commit
    branch feat/my-feature
    checkout feat/my-feature
    commit
    commit
    checkout develop
    merge feat/my-feature id: "pull request"
    commit
    checkout stable
    merge develop id: "official release" tag:"v0.1.0"
```

> Why not create release tags directly off of the `develop` branch?

This is definitely a valid strategy. We prefer to follow a pull request oriented workflow whenever possible as it allows for a natural checkpoint before triggering the next part of a process. Tagging directly off of `develop` wouldn't allow for that.

> Does the `develop` branch cause long delays in shipping smaller releases?

We haven't noticed much delay in getting minor or patch versions released with this model, but it's a risk if maintainers aren't properly keeping up with the repository changes. If a change you've made hasn't been released in a timely manner please do raise an issue and let us know!
