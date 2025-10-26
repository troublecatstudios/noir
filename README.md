# Noir Library
Noir is our helper library for unity-based games.

[![release][release-badge]][release]
[![license][license-badge]][license]
![unity][unity-badge]
![GitHub Actions Workflow Status][build-badge]

[Docs](./docs/index.md) | [Changelog](./package/CHANGELOG.md) | [License](./package/LICENSE.md)

> [!Note]
> This library includes DLLs for several open source libraries. Their license information as well as instructions for removing them if you encounter conflicts when installing can be found in the [Package README](./package/README.md).

**Supported Unity Versions**: v2021.3+

## Installation

Noir can [be installed as a unity package](https://docs.unity3d.com/Manual/upm-ui-giturl.html) using this url:

```
https://github.com/troublecatstudios/noir-unity.git?path=/package#v1.0.0
```


## Contributing

The project is broken out into two main directories:

 - `package` contains all the source files, dependencies, and documentation for the noir package.
 - `unity-project` is a Unity project that is setup to build out samples for inclusion in the final published version of the package.

For more info, see our [contribution guidelines](./CONTRIBUTING.md).

<!-- badge links -->

[release]: https://github.com/troublecatstudios/noir/releases
[release-badge]: https://img.shields.io/github/v/release/troublecatstudios/noir?style=for-the-badge&logo=github
[unity-badge]: https://img.shields.io/badge/Unity-v2023.3%2B-blue?style=for-the-badge
[license]: ./package/LICENSE.md
[license-badge]: https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge
[build-badge]: https://img.shields.io/github/actions/workflow/status/troublecatstudios/noir/build.yaml?style=for-the-badge
