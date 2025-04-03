using System.Collections.Generic;
using Noir.Attributes;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Samples.Basic.AutoCreateAssets {
    [AutomaticallyCreate(customPathPrefix: "TroubleCatStudios/Noir/Resources/", assetNameOverride: "SamplesSceneList")]
    public class SamplesSceneList : ScriptableObject {
        public static SamplesSceneList Instance {
            get {
                var list = Resources.Load<SamplesSceneList>($"{nameof(SamplesSceneList)}");
                return list;
            }
        }

        [Scene] public string MainSampleScene;
    }
}