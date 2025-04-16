# Action Version

This is a GitHub Action to bump the project version. It uses the base version specified in the `./version.json` file.

For example:

- If `version.json` specifies `1.0.0` and `release_type=major` -> `new_version=2.0.0`
- If `version.json` specifies `1.2.3` and `release_type=major` -> `new_version=2.0.0`
- If `version.json` specifies `1.2.3` and `release_type=minor` -> `new_version=1.3.0`

Its more useful to use this with other GitHub Actions' outputs.

## Inputs

|       NAME        |                                       DESCRIPTION                                        |   TYPE   | REQUIRED | DEFAULT |
|-------------------|------------------------------------------------------------------------------------------|----------|----------|---------|
| `release_type`    | A semver update level ({major, minor, patch}).                                           | `string` | `false`  | `patch` |

## Outputs

|     NAME      |        DESCRIPTION         |   TYPE   |
|---------------|----------------------------|----------|
| `new_version` | The bumped semver version. | `string` |

## License

Copyright (c) 2025 Trouble Cat Studios.

Action Version is released under the [MIT License](./../../../package/LICENSE.md).
