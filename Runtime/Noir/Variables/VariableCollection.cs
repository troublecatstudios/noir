using System.Collections.Generic;
using UnityEngine;

namespace Noir.Variables {
    [CreateAssetMenu(fileName = "VariableCollection.asset", menuName = "Noir/Data/Variable Collection", order = 0)]
    public class DataVariableCollection : ScriptableObject {
        public List<DataVariable> Variables;
    }
}