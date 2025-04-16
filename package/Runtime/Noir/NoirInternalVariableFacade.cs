using Noir.DataObjects;
using Noir.Variables;

namespace Noir {
    internal static class NoirInternalVariableFacade {
        private const string DebugShowEventDispatchesName = "b_DebugShowEventDispatches";

        private static BooleanVariable _debugShowEventDispatchesVariable = null;
        private static bool _debugShowEventDispatches = false;

        public static bool DebugShowEventDispatches {
            get {
                if (!_debugShowEventDispatchesVariable && !TryGetVariable<BooleanVariable>(DebugShowEventDispatchesName, out _debugShowEventDispatchesVariable)) {
                    return _debugShowEventDispatches;
                }
                return _debugShowEventDispatchesVariable.Value;
            }
            set {
                if (!_debugShowEventDispatchesVariable && !TryGetVariable<BooleanVariable>(DebugShowEventDispatchesName, out _debugShowEventDispatchesVariable)) {
                    _debugShowEventDispatches = value;
                    return;
                }
                _debugShowEventDispatchesVariable.Value = value;
            }
        }

        private static bool TryGetVariable<T>(string name, out T variable) where T : DataVariable {
            variable = NoirDataLibrary.Instance.GetVariableByName<T>(name);
            if (!variable) {
                return false;
            }

            return true;
        }
    }
}