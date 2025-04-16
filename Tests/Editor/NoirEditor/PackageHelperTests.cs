using NExpect;
using Noir.Testing;
using NoirEditor;
using NUnit.Framework;
using System;
using System.IO;
using static NExpect.Expectations;

namespace NoirEditModeTests.NoirEditor {
    public class PackageHelperTests : NoirTestCase {

        [Test]
        public void GetPackageDirectoryRoot_ReturnsTheAbsolutePathToThePackageDirectory() {
            var folder = PackageHelper.GetPackageDirectoryRoot();
            Expect(Path.IsPathRooted(folder)).To.Be.True();
        }

        [Test]
        public void GetPackageDirectoryRoot_ReturnsAFolderThatExists() {
            var folder = PackageHelper.GetPackageDirectoryRoot();
            var directoryInfo = new DirectoryInfo(folder);
            Expect(directoryInfo.Exists).To.Be.True();
        }

        [Test]
        public void GetPackagesDirectoryRoot_DoesNotReturnTheSameDirectoryPathAsTheCurrentProject() {
            var folder = PackageHelper.GetPackageDirectoryRoot();
            var currentDirectoryAbsolutePath = Path.GetFullPath(Environment.CurrentDirectory);
            Expect(folder).Not.To.Start.With(currentDirectoryAbsolutePath);
        }
    }
}