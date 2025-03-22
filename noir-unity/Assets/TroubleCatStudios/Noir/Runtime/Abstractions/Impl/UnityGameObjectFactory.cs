using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Noir.Unity.Abstractions.Impl {
    public class UnityGameObjectFactory : AbstractGameObjectFactory {
        public override AbstractGameObject CreateInstance(AbstractGameObject original, AbstractTransform parent) {
            var clone = original.Clone();
            clone.transform.parent = parent;
            return clone;
        }
    }
}
