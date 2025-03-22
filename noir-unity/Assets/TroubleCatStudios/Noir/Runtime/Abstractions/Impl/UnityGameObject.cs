using UnityEngine;

namespace Noir.Unity.Abstractions.Impl {
    public class UnityGameObject : AbstractGameObject {
        private readonly GameObject _backingGameObject;
        private readonly UnityTransform _transform;

        public UnityGameObject() { }
        public UnityGameObject(GameObject gameObject) {
            _backingGameObject = gameObject;
            _transform = new UnityTransform(gameObject.transform);
        }

        public override string name => _backingGameObject.name;

        public override AbstractTransform transform => _transform;

        public override void SetActive(bool active) => _backingGameObject.SetActive(active);

        public override AbstractGameObject Clone() {
            var go = GameObject.Instantiate(_backingGameObject);
            return new UnityGameObject(go);
        }
    }
}
