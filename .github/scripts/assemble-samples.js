/*******************************************************************
* Copyright         : 2025 Trouble Cat Studios
* File Name         : assemble-samples.js
* Description       : A script to pull the package project samples from a Unity project setup as a sibling directory to this scripts parent project.
*                     For example, if this project was clone to /Users/tim/noir then the sample Unity project should exist at the root of /Users/tim/.
*
/******************************************************************/

const fs = require('fs');
const path = require('path');

const { walkDirSync, hasAnyDirs, hasDirs } = require('./utils');

const expectedUnityDirectories = ['Library', 'ProjectSettings', 'Temp', 'UserSettings', 'Packages'];
const requiredUnityProjectDirectories = ['Assets'];
const repositoryRoot = path.resolve(__dirname, '../..');

const samplesProjectName = 'noir-dev';
const targetProjectRoot = path.resolve(repositoryRoot, '../', samplesProjectName);

const SamplesProjectDirectoryNotFound = `Samples directory could not be found.`;
const SamplesProjectIsNotValidUnityProject = `Samples source project does not appear to be a valid Unity project`;

const assembleSamples = () => {
  const samplesDirAbsolutePath = path.resolve(repositoryRoot, `./Samples`);
  const targetSamplesDir = path.resolve(targetProjectRoot, './Assets/Samples');

  if (!fs.existsSync(samplesDirAbsolutePath)) {
    throw SamplesProjectDirectoryNotFound;
  }

  const isUnityProject = hasAnyDirs(targetProjectRoot, ...expectedUnityDirectories) && hasDirs(samplesDirAbsolutePath, ...requiredUnityProjectDirectories);
  if (!isUnityProject) {
    throw SamplesProjectIsNotValidUnityProject;
  }

  const allFiles = walkDirSync(targetSamplesDir);

};


