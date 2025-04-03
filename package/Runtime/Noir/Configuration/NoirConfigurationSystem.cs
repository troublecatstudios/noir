using UnityEngine;

namespace Noir.Configuration {
    public class NoirConfigurationSystem : INoirProjectConfigurationAccessor {
        private static readonly NoirConfigurationSystem _instance = new();

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void SubsystemRegistration() {
            ServiceLocator.RegisterService<INoirProjectConfigurationAccessor>(_instance);
        }

        public NoirProjectConfiguration GetProjectConfiguration() {
            return NoirProjectConfiguration.Instance;
        }
    }
}