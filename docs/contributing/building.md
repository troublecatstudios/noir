# Noir Library Build & Release Process

## Build process

The build process is run anytime a pull request is opened or updated.

```mermaid
---
title: Noir Build Process
---
graph TD
    unity(("open ./unity-project in Unity"))
    run_edit_tests(["run EditMode tests"])
    run_play_tests(["run PlayMode tests"])
    done

    unity --> run_edit_tests
    unity --> run_play_tests
    run_play_tests --> done
    run_edit_tests --> done

```


## Release process

The release process is run anytime a pull request is merged into the `stable` branch.

```mermaid
---
title: Noir Release Process
---
graph TD
    release(("release triggered"))
    version(["increment version from PR labels"])
    mk_tag(["create git tag for release"])
    cp_samples(["copy samples to ./package/Samples~/"])
    mk_changelog(["build changelog from PR description"])
    mk_docs(["generate code docs to ./package/Docs~/"])
    commit(["push changes to new tag"])
    done

    release --> version
    version --> mk_tag
    mk_tag --> cp_samples
    cp_samples --> mk_changelog
    mk_changelog --> mk_docs
    mk_docs --> commit
    commit --> done

```
