const fs = require('fs/promises');
const path = require('path');
const nbgv = require('nerdbank-gitversioning');
const semver = require('semver');
const { log, err, warn } = require('../../scripts/utils');
const repositoryRootPath = path.resolve(__dirname, '../../../');
const packageDirectory = path.resolve(repositoryRootPath, './package');
const packageJsonFile = path.resolve(packageDirectory, './package.json');
const versionFile = path.resolve(repositoryRootPath, './version.json');
const args = process.argv.slice(2);

(async function main(releaseType) {
  try {
    if (releaseType === 'reset') {
      log(`setting package version to 0.0.0-placeholder`);
      await nbgv.resetPackageVersionPlaceholder(packageDirectory);
      return;
    }

    const { version } = require(versionFile);
    const { GITHUB_SHA, GITHUB_RUN_ID, GITHUB_REF, GITHUB_HEAD_REF } = process.env;
    let versionSuffix = [];

    if (['dev', 'alpha', 'beta', 'rc'].includes(releaseType)) {
      versionSuffix = [
        releaseType,
        GITHUB_SHA.substring(0, 8),
        GITHUB_RUN_ID
      ];
    }

    let newVersion = [
      semver.major(version),
      semver.minor(version),
      semver.patch(version),
    ].join('.');

    if (versionSuffix.length > 0) {
      newVersion = `${newVersion}-${versionSuffix.join('.')}`;
    }

    log(`updating package version`, { newVersion })
    const pkg = require(packageJsonFile);
    pkg.version = newVersion;
    await fs.writeFile(packageJsonFile, JSON.stringify(pkg, null, 2));
  } catch (e) {
    err(`error while updating package version`, e);
    console.error(e);
    process.exit(1);
  }
})(...args);
