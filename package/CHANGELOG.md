# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

Noir has been updated to follow the new patterns and practices for Unity Packages.

### Added
- docs: Project and API documentation is handled via [mkdocs](https://www.mkdocs.org/) and a new site is generated automatically in the [material for mkdocs](https://squidfunk.github.io/mkdocs-material/) system.
- runtime: Noir includes Variables, ScriptableObject-backed data stores that can be referenced in Behaviours, other ScriptableObjects or even directly within C# code.
- runtime: Noir includes a basic ServiceLocator allowing for basic decoupling of objects without depending on heavy dependency injection frameworks.
- runtime: Noir includes an event dispatcher that is built upon the existing eventing system within Unity.
- runtime; Noir includes both a `NoirBehaviour` and `NoirSingletonBehaviour<>` that enable easy access to Noir's `ServiceLocator`, `EventDispatcher` and `Logger`.
- runtime: Noir includes a high-performance file-based logger that is wired into Unitys `Debug.Log()` to ensure you never miss an important log message during debugging.
- runtime: Noir includes SoundEffects, ScriptableObject wrappers for your audio clips that can be played via C# code or using Noir Events.
- runtime: Noir includes several helper classes that make working with randomness easier. Use algorithms like Mersenne Twister, Halton Sequence, Poisson Disc and Noise efficiently and without writing lots of code.
- runtime: Noir includes a generic object pooling system that makes reusing prefabs easy.
- ci: API documentation is automatically updated when pull requests are opened
- ci: documentation is automatically posted to the [documentation site](https://troublecat.io/noir) when pull requests are merged the develop branch
- editor: NoirEditor is designed to work with or without [Odin Inspector](https://odininspector.com/), allowing you to take advantage of Noirs key features regardless of your editor setup.
- editor: NoirEditor includes code to make writing unit tests in Unity easier.
- editor: NoirEditor automatically generates C# code files for Tags, Scenes, Layers, SortingLayers, Unity StyleSheets and Noir Variables, allowing you to reference them via code easily and know when changes break functionality.


<!--begin_changelog-->

## [v0.0.1] 2022-04-28

- Add: includes the AssetDatabaseUtility class as part of the Noir.Unity package
