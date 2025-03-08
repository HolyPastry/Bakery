using UnityEditor;

namespace Holypastry.Bakery.Editor
{
    public static class DefaultSetup
    {

        [MenuItem("Holypastry/Default Setup")]
        public static void CreateDefaultFolder()
        {
            Folders.Create("_Content", "Animation", "Resources", "3DArt", "2DArt", "Music", "Audio", "Prefabs", "ScriptableObjects", "Scenes", "Scripts", "Settings");
            Folders.Create("_Features");
            Packages.Install(new[]
            {
                "https://github.com/KyleBanks/scene-ref-attribute.git",
                "https://github.com/starikcetin/Eflatun.SceneReference.git#upm",
                "com.unity.cinemachine",
                "com.unity.textmeshpro",
                "com.unity.inputsystem"
            });
        }
    }
}