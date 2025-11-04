using Noir.Testing;
using NoirEditor;
using NUnit.Framework;

namespace NoirEditModeTests.NoirEditor {
    public class PlatformHelperTests : NoirEditModeTestCase {

        [TestCase("/rooted/nix/path", '/', ExpectedResult = "/rooted/nix/path")]
        [TestCase("/rooted/nix/path", '\\', ExpectedResult = "/rooted/nix/path")]
        [TestCase("//rooted/nix/path", '/', ExpectedResult = "//rooted/nix/path")]
        [TestCase("//rooted/nix/path", '\\', ExpectedResult = "//rooted/nix/path")]
        [TestCase("nix/path", '/', ExpectedResult = "nix/path")]
        [TestCase("nix/path", '\\', ExpectedResult = "nix/path")]
        [TestCase("C:/windows/path", '/', ExpectedResult = "C:/windows/path")]
        [TestCase("C:\\windows\\path", '\\', ExpectedResult = "C:/windows/path")]
        [TestCase("windows/path", '/', ExpectedResult = "windows/path")]
        [TestCase("windows\\path", '\\', ExpectedResult = "windows/path")]
        public string NormalizePath_ShouldReturnNixStylePathsAlways(string inputPath, char separator) {
            var helper = new PlatformHelper(separator);
            return helper.NormalizePath(inputPath);
        }
    }
}