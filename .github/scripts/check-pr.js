const releaseNotesRegex = /```release_note([\s\S]*)```/ig;
module.exports = async ({github, context, core, pr}) => {
  const {body} = pr;
  let reasons = [];
  let warnings = [];
  let remarks = [];

  // check that the PR has a release_notes section
  const hasReleaseNotes = releaseNotesRegex.test(body);
  // check for release label
  const releaseLabels = pr.labels.map(l => l.name).filter(l => l.startsWith('release/'));

  if (releaseLabels.length > 0) {
    if (releaseLabels.length > 1) {
      reasons.push('* Too many release labels. Please remove one of the release/* labels from this PR.');
      core.warning('Too many release labels.');
    }
    if (!hasReleaseNotes) {
      reasons.push('* Missing release notes section. You\'ve specified at least one release/* label without any release notes.');
      core.warning('Missing release notes section');
    }
  } else {
    if (hasReleaseNotes) {
      warnings.push('* You\'ve added some release notes but haven\'t added a release/* label.');
      core.warning('Missing release labels.');
    } else {
      remarks.push('This pull request will not update the release, it is a develop-only pull request.');
    }
  }

  if (reasons.length > 0) {
    core.setOutput('reasons', '### :no_entry: Lint Failures\n' + reasons.join('\n'));
  } else {
    core.setOutput('reasons', '');
  }

  if (warnings.length > 0) {
    core.setOutput('warnings', '### :warning: Lint Warnings \n' + warnings.join('\n'));
  } else {
    core.setOutput('warnings', '');
  }

  if (remarks.length > 0) {
    core.setOutput('remarks', '### :memo: Lint Remarks \n' + remarks.join('\n'));
  } else {
    core.setOutput('remarks', '');
  }

  if (reasons.length > 0) {
    core.setFailed('Pull request failed to pass validation.');
  }
}
