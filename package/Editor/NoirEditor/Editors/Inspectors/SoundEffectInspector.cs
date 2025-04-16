using System.Collections;
using Noir.Audio;

#if UNITY_6_OR_NEWER
using Unity.EditorCoroutines.Editor;
#else
using NoirEditor.EditorCoroutines;
#endif

using UnityEditor;
using UnityEngine;

namespace NoirEditor.Editors.Inspectors {
    [CustomEditor(typeof(SoundEffect))]
    internal class SoundEffectInspector : Editor {
        private bool _isPlaying = false;
        public override void OnInspectorGUI() {
            base.OnInspectorGUI();

            var sfx = (SoundEffect)target;

            GUI.enabled = !_isPlaying;
            if (GUILayout.Button("Play")) {
                EditorCoroutineUtility.StartCoroutine(PlayClip(sfx), this);
            }
        }

        private IEnumerator PlayClip(SoundEffect sfx) {
            _isPlaying = true;
            InternalUnityEditor.Audio.StopAllClips();
            var clip = sfx.GetClip();
            InternalUnityEditor.Audio.PlayClip(clip);
            Debug.Log($"SoundEffect '{sfx.name}' Previewing Clip '{clip.name}'", clip);
            while (InternalUnityEditor.Audio.IsPreviewClipPlaying()) {
                yield return null;
            }
            _isPlaying = false;
        }
    }
}