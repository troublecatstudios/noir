using Noir.Audio;
using Noir.DataObjects;
using Noir.Variables;
using UnityEditor;

namespace NoirEditor {
    internal class DataLibraryBuilder {
        private const string DataDirectory = "Assets/Data";
        private const string TexturesDirectory = "Assets/Textures";

        public static void UpdateDataLibrary(NoirDataLibrary library) {
            library.SoundEffects = AssetDB.Load<SoundEffect>("t:SoundEffect", searchPaths: DataDirectory);
            library.Variables = AssetDB.Load<DataVariable>("t:DataVariable", searchPaths: DataDirectory);

            EditorUtility.SetDirty(library);
        }
    }
}