using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Noir {
    public class UnityScene {
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