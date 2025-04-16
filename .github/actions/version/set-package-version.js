const fs = require('fs/promises');
const path = require('path');
const nbgv = require('nerdbank-gitversioning');
const semver = require('semver');
const { log, err, warn } = require('../../scripts/utils');
const repositoryRootPath = path.resolve(__dirname, '../../../');
const packageDirectory = path.resolve(repositoryRootPath, './package');
const nerdbankVersionFile = path.resolve(repositoryRootPath, './version.json');

const args = process.argv.slice(2);

const validReleaseTypes = ['major', 'minor', 'patch'];
const versionRegex = /^v\d{1,}\.\d{1,}\.\d{1,}-?/i;

(async function main(releaseType) {
  try {
    if (releaseType === 'reset') {
      log(`setting package version to 0.0.0-placeholder`);
      await nbgv.resetPackageVersionPlaceholder(packageDirectory);
      return;
    }
    if (versionRegex.test(releaseType)) {
      log(`specific version passed. will set version to ${releaseType}`);
    } else if (!validReleaseTypes.includes(releaseType)) {
      err(`error while updating package version. invalid release type: '${releaseType}'`);
      process.exit(1);
    }
    const nbVersion = require(nerdbankVersionFile);
    const [prereleaseLabel, prerelease] = semver.prerelease(nbVersion.version) || [];
    let newVersion = semver.inc(nbVersion.version, releaseType);
    if (prereleaseLabel) {
      // special handling of cases where we want to bump the major/minor/patch
      // component but we've set the nerdbank version to a prerelease
      log(`detected prerelease base version`, { version: nbVersion.version });
      releaseType = `pre${releaseType}`;
      newVersion = semver.inc(nbVersion.version, releaseType, false, prereleaseLabel);
    }

    log(`updating base version ${releaseType} component`, {
      oldVersion: nbVersion.version,
      newVersion,
    });
    nbVersion.version = newVersion;
    log(`updating nerdbank version file`, { newVersion });
    await fs.writeFile(nerdbankVersionFile, JSON.stringify(nbVersion, null, 2));
    log(`updating package version`)
    await nbgv.setPackageVersion(packageDirectory, repositoryRootPath);
  } catch (e) {
    err(`error while updating package version`, e);
    console.error(e);
    process.exit(1);
  }
})(...args);
