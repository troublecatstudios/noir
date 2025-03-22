namespace Noir.Unity.Abstractions {
    public interface IComponentResolver {
        T GetComponent<T>();
        T[] GetComponents<T>();
        T GetComponentInChildren<T>();
        T[] GetComponentsInChildren<T>();
        T GetComponentInParents<T>();
        T[] GetComponentsInParents<T>();
    }
}
