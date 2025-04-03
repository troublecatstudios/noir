using System;
using Noir;
using Noir.Audio;
using Noir.Audio.Events;
using Noir.Events;
using Samples;
using UnityEngine;

public class AudioSourcePoolExample : MonoBehaviour
{

    [Help("These AudioClips will be played via a button when the scene is in play mode.")]
    [SerializeField] private AudioClip[] _clips;

    private INoirAudioManager _audioManager;

    private void Start()
    {
        _audioManager = ServiceLocator.GetService<INoirAudioManager>();
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 128, 64, 256, 128), "Play a random AudioClip", SamplesGUI.HeaderTextStyle());

        if (GUI.Button (new Rect (128, 128, 256, 128), "Play Direct"))
        {
            var clip = _clips.Random();
            _audioManager.TryPlayClip(clip);
        }

        if (GUI.Button (new Rect (128, 128 + 20 + 128, 256, 128), "Play via Event"))
        {
            var eventDispatcher = ServiceLocator.GetService<INoirEventDispatcher>();
            var clip = _clips.Random();
            eventDispatcher.DispatchEvent<PlayAudioClipEvent>(new()
            {
                Clip = clip,
            });
        }
    }
}