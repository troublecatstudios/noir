## Third Party Libraries

Noir makes use of several third-party libraries, which are included in binary format with this package. You can read the licensing information for these libraries in the included [third party notices](./third_party_notices.md).

!!! Note
    We'll eventually migrate these dependencies over to proper UPM dependency references, but until then if your project already includes versions of these libraries you should move the `Editor`, `Runtime`, `Tests` folders into a separate sub directory of your Unity Project. Then you can move/remove any binary dependencies as needed from the project.
