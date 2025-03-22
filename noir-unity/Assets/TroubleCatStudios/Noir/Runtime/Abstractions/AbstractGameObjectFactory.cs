namespace Noir.Unity.Abstractions {
    public abstract class AbstractGameObjectFactory {
        public abstract AbstractGameObject CreateInstance(AbstractGameObject original, AbstractTransform parent);
    }
}
