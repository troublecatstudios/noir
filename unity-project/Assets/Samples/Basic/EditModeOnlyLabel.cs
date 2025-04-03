using Noir;
using System;
using UnityEngine;

namespace Samples {
    public class EditModeOnlyLabel : NoirBehaviour {
        public Vector2 LabelPosition;
        public string LabelText;

        private void OnDrawGizmos() {
            if (Application.isPlaying) return;
            UnityEditor.Handles.Label(LabelPosition, LabelText, SamplesGUI.EditModeLabelStyle());
        }
    }
}