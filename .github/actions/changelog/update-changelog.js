const fs = require('fs/promises');
const path = require('path');

const { log, err, warn } = require('../../scripts/utils');

const repositoryRootPath = path.resolve(__dirname, '../../../');
const packageDirectory = path.resolve(repositoryRootPath, './package');
const changelogFile = path.resolve(packageDirectory, './CHANGELOG.md');

const UnreleasedChangesMarker = `## [Unreleased]`;
const ChangelogBeginMarker = `<!--begin_changelog-->`;

async function main(newVersion) {
  const changelogContents = (await fs.readFile(changelogFile)).toString();
  // get the unreleased contents
  const start = changelogContents.indexOf(UnreleasedChangesMarker) + UnreleasedChangesMarker.length;
  const end = changelogContents.indexOf(ChangelogBeginMarker);
  const changes = changelogContents.slice(start, end);

  const now = new Date();
  const newSection = [
    '',
    ChangelogBeginMarker,
    '',
    `## [${newVersion}] - ${now.getFullYear()}-${now.getMonth() + 1}-${now.getDate()}`,
    changes,
  ];

  const updatedChangelog = [
    changelogContents.slice(0, start),
    '',
    ...newSection,
    changelogContents.slice(end + ChangelogBeginMarker.length),
  ];

  await fs.writeFile(changelogFile, updatedChangelog.join('\n'));

  return changes;
}

module.exports = {
  updateChangelog: main,
};

if (!process.env['GITHUB_ACTIONS']) {
  const args = process.argv.slice(2);
  (async function wrapper(){
    try {
      const changes = await main(...args);
      log(changes);
    } catch (e) {
      err(`error while updating changelog`, e);
      console.error(e);
      process.exit(1);
    }
  })();
}
