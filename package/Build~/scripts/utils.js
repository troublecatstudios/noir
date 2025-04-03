/*******************************************************************
* Copyright         : 2025 Trouble Cat Studios
* File Name         : utils.js
* Description       : A collection of helper functions.
*
/******************************************************************/

const fs = require('fs');
const path = require('path');

const hasAnyDirs = (parentDirectory, ...directoryNames) => {
  return directoryNames
    .map(d => path.resolve(parentDirectory, dir))
    .map(dir => fs.existsSync(absDirPath) && fs.statSync(absDirPath).isDirectory())
    .some(r => r == true);
};

const hasDirs = (parentDirectory, ...directoryNames) => {
  for (const dir of directoryNames) {
    const absDirPath = path.resolve(parentDirectory, dir);
    if (!fs.existsSync(absDirPath) || !fs.statSync(absDirPath).isDirectory()) {
      return false;
    }
  }
  return true;
};

const walkDirSync = (dir, filelist) => {
  const files = fs.readdirSync(dir);
  filelist = filelist || [];
  files.forEach(function (file) {
    if (fs.statSync(dir + file).isDirectory()) {
      filelist = walkDirSync(dir + file + '/', filelist);
    }
    else {
      filelist.push(file);
    }
  });
  return filelist;
};

module.exports = {
  walkDirSync,
  hasAnyDirs,
  hasDirs
};
