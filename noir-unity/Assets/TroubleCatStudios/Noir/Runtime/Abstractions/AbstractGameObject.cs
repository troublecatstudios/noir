namespace Noir.Unity.Abstractions {
    public abstract class AbstractGameObject {
        public abstract string name { get; }
        public abstract AbstractTransform transform { get; }
        public abstract void SetActive(bool active);
        public abstract AbstractGameObject Clone();
    }
}
