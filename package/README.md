# Noir
Noir is our helper library for unity-based games.

[CHANGELOG](./CHANGELOG.md) | [LICENSE](./LICENSE.md) | [Third Party Notices](./Third%20Party%20Notices.md)


### Third Party Libraries

Noir makes use of several third-party libraries, which are included in binary format with this package. You can read the licensing information for these libraries in the included [third party notices](./Third%20Party%20Notices.md).

!!! Note
    We'll eventually migrate these dependencies over to proper UPM dependency references, but until then if your project already includes versions of these libraries you should move the `Editor`, `Runtime`, `Tests` folders into a separate sub directory of your Unity Project. Then you can move/remove any binary dependencies as needed from the project.
