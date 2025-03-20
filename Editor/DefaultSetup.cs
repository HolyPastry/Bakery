using UnityEditor;

namespace Holypastry.Bakery.Editor
{
    public static class DefaultSetup
    {

        [MenuItem("Bakery/Default Project Setup")]
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

        [MenuItem("Bakery/Default Package Setup")]
        public static void CreateDefaultPackage()
        {
            Folders.Create("PackageName", "Editor", "Runtime");
            Folders.Create("Samples");
        }


    }
}