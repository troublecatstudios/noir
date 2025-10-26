using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Noir {
    /// <summary>
    /// Provides utility methods for working with the Unity scene hierarchy.
    /// </summary>
    public class UnityScene {
        /// <summary>
        /// Finds all components of type <typeparamref name="T"/> in all loaded scenes and adds them to the provided list.
        /// </summary>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="result">The list to populate with found components. This list will be cleared before use.</param>
        public static void Find<T>(List<T> result)
        {
            result.Clear();
            for (int i = 0; i < SceneManager.sceneCount; i++)
            {
                GameObject[] rootGameObjects = SceneManager.GetSceneAt(i).GetRootGameObjects();
                for (int j = 0; j < rootGameObjects.Length; j++)
                {
                    T[] componentsInChildren = rootGameObjects[j].GetComponentsInChildren<T>();
                    result.AddRange(componentsInChildren);
                }
            }
        }
    }
}