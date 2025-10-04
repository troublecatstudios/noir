# Action Changelog

This is a GitHub Action to move entries under the `## [Unreleased]` section of the [CHANGELOG](./../../../package/CHANGELOG.md) to a new section with the specified version header.

Its more useful to use this with other GitHub Actions' outputs.

## Inputs

|       NAME        |                                       DESCRIPTION                                        |   TYPE   | REQUIRED | DEFAULT |
|-------------------|------------------------------------------------------------------------------------------|----------|----------|---------|
| `version`         | The version label to use for the new header.                                             | `string` | `true`   |         |

## Outputs

|     NAME      |        DESCRIPTION                                       |   TYPE   |
|---------------|----------------------------------------------------------|----------|
| `content`     | The contents of the CHANGELOG that were moved.           | `string` |

## License

Copyright (c) 2025 Trouble Cat Studios.

Action Version is released under the [MIT License](./../../../package/LICENSE.md).
