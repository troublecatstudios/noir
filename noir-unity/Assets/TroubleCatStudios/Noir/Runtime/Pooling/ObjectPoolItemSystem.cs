#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;

namespace Noir.Pooling {
    /// <summary>
    /// Represents an object that is owned by a <see cref="ObjectPool"/>.
    /// </summary>
    /// <seealso cref="Noir.NoirBehaviour" />
    [AddComponentMenu("Noir/Spawning/Object Pool Item")]
    public class ObjectPoolItemSystem : NoirBehaviour {
        private ObjectPool _pool;
#if ODIN_INSPECTOR
        [ShowInInspector]
        [ReadOnly]
 #endif
        private uint _id;

        private bool _isReturned = false;
        private ObjectPoolItemState _state = ObjectPoolItemState.Inactive;

        public uint Id => _id;

        public bool IsReturned => _isReturned;

        public ObjectPoolItemState State => _state;

        private void OnDisable() {
            if (_isReturned) return;
            ReturnToPool();
        }

        public event OnPoolItemCreatedEvent OnCreated;

        public event OnPoolItemRetrievedEvent OnRerievedFromPool;

        public event OnPoolItemReturnedEvent OnReturnedToPool;

        protected virtual void OnItemRetrieved() { }
        protected virtual void OnItemReturned() { }

        /// <summary>
        /// Called when the object has been retrieved from an <see cref="ObjectPool"/>.
        /// </summary>
        internal void RetrievedFromPool() {
            OnItemRetrieved();
            gameObject.SetActive(true);
            _state = ObjectPoolItemState.Active;
            _isReturned = false;
            OnRerievedFromPool?.Invoke(this);
        }

        /// <summary>
        /// Called when the object has been returned to an <see cref="ObjectPool"/>.
        /// </summary>
        internal void ReturnedToPool() {
            OnItemReturned();
            _isReturned = true;
            _state = ObjectPoolItemState.Inactive;
            OnReturnedToPool?.Invoke(this);
            if (gameObject.activeSelf) {
                gameObject.SetActive(false);
            }
        }

        /// <summary>
        /// Called when the item is created within a pool for the first time.
        /// </summary>
        /// <param name="pool">The pool this item belongs to.</param>
        internal void CreatedByPool(ObjectPool pool, uint id) {
            _id = id;
            _pool = pool;
            _state = ObjectPoolItemState.Inactive;
            OnCreated?.Invoke(this);
        }

        /// <summary>Returns the current object back to the pool.</summary>
        /// <remarks>This should be called after any cleanup has been run within the objects other components.</remarks>
        [ContextMenu("Noir/Return To Pool")]
#if ODIN_INSPECTOR
        [EnableIf("@State == ObjectPoolItemState.Active")]
        [DisableInEditorMode]
        [Button(ButtonSizes.Large), GUIColor(GUIColors.Action)]
#endif
        public void ReturnToPool() {
            if (_isReturned) return;
            _state = ObjectPoolItemState.Returning;
            _pool.Return(this);
        }
    }
}