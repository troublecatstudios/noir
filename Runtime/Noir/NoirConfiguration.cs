using UnityEngine;

namespace Noir {
    /// <summary>
    /// Stores configuration options for the Noir library.
    /// </summary>
    public class NoirConfiguration : ScriptableObject {
        public static bool HasFirstTimeSetupRun() {
            // attempt to load the config from resources
            var config = Resources.Load<NoirConfiguration>("noir-configuration.asset");
            if (config) {
                return true;
            }

            return false;
        }

        internal static void RunFirstTimeSetup() {

        }
    }
}