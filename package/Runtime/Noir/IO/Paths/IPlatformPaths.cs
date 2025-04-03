namespace Noir.IO.Paths {
    public interface IPlatformPaths {
        string ConfigurationDirectory { get; }
        string SaveFileDirectory { get; }
        string LogDirectory { get; }
    }
}