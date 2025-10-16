using Noir.DependencyInjection;
using System;
using Noir.Events;
using Noir.Logging;
using UnityEngine;

namespace Noir {
    /// <summary>
    /// Base class for Noir MonoBehaviour scripts, providing easy access to logging, time, services, and event dispatching.
    /// </summary>
    public class NoirBehaviour : MonoBehaviour {
        private readonly Guid _guid = Guid.NewGuid();
        private ComponentServiceLocator _services = null;

        /// <summary>
        /// Gets a logger specific to this behaviour instance.
        /// </summary>
        protected BehaviourLogger Logger => new(this);

        /// <summary>
        /// Gets the <see cref="GameTime"/> service from the global service locator.
        /// </summary>
        protected GameTime GameTime => ServiceLocator.GetService<GameTime>();

        /// <summary>
        /// Dispatches a Noir event using the global <see cref="INoirEventDispatcher"/>.
        /// </summary>
        /// <typeparam name="T">The type of the event info to dispatch.</typeparam>
        /// <param name="eventInfo">The event information to dispatch.</param>
        protected void DispatchEvent<T>(T eventInfo) {
            ServiceLocator.GetService<INoirEventDispatcher>().DispatchEvent<T>(eventInfo);
        }

        /// <summary>
        /// Registers this GameObject as a listener for events of type <typeparamref name="T"/> using the global <see cref="INoirEventRegistry"/>.
        /// </summary>
        /// <typeparam name="T">The type of event to listen for.</typeparam>
        protected void RegisterListener<T>() {
            ServiceLocator.GetService<INoirEventRegistry>().Register<T>(gameObject);
        }

        /// <summary>
        /// Unregisters this GameObject as a listener for events of type <typeparamref name="T"/> using the global <see cref="INoirEventRegistry"/>.
        /// </summary>
        /// <typeparam name="T">The type of event to stop listening for.</typeparam>
        protected void UnregisterListener<T>() {
            ServiceLocator.GetService<INoirEventRegistry>().Unregister<T>(gameObject);
        }

        /// <summary>
        /// Gets the <see cref="ComponentServiceLocator"/> for this GameObject, initializing it if necessary.
        /// </summary>
        protected ComponentServiceLocator Services {
            get {
                if (_services == null) _services = new(gameObject);
                return _services;
            }
        }

        /// <summary>
        /// Returns a string representation of this behaviour, including its unique identifier.
        /// </summary>
        /// <returns>A string containing the unique identifier for this behaviour.</returns>
        public override string ToString() {
            return $"id={_guid}";
        }
    }
}