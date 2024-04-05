using UnityEditor;

namespace Holypastry.Bakery.Editor
{
    public static class DefaultSetup
    {

        [MenuItem("Holypastry/Tools/Create Default Folders")]
        public static void CreateDefaultFolder()
        {
            Folders.Create("_Project", "Animation", "Art", "Materials", "Prefabs", "ScriptableObjects", "Scenes", "Scripts", "Settings");
            AssetDatabase.Refresh();
        }

        [MenuItem("Holypastry/Tools/Import Base Unity Packages")]
        public static void ImportMyFavoriteAssets()
        {
            Packages.Install(new[]
            {
                "com.unity.cinemachine",
                "com.unity.inputsystem",
                "com.unity.textmeshpro",
            });
        }

        [MenuItem("Holypastry/Tools/Install GitPackages")]
        public static void InstallGitPackages()
        {
            Packages.Install(new[]
          {
                "https://github.com/KyleBanks/scene-ref-attribute.git",
                "https://github.com/starikcetin/Eflatun.SceneReference.git#upm"

            });
        }

        [MenuItem("Holypastry/Tools/Install Dotween")]
        public static void InstallDotween()
        {
            Assets.Import("DOTween HOTween v2", "Demigiant/Editor ExtensionsAnimation");
        }

        [MenuItem("Holypastry/Tools/Install Prototype Materials")]
        public static void InstallPrototypeMaterials()
        {
            Assets.Import("Grid Prototype Materials", "MLAgent/Textures Materials");
        }


        [MenuItem("Holypastry/Tools/Install Splines")]
        public static void InstallMLAgents()
        {
            Packages.Install(new[] { "com.unity.splines" });
        }

        [MenuItem("Holypastry/Tools/Install AI Navigation")]
        public static void InstallAINavigation()
        {
            Packages.Install(new[] { "com.unity.ai.navigation" });
        }

        //install netcode for gameobjects
        [MenuItem("Holypastry/Tools/Install Netcode for GameObjects")]
        public static void InstallNetcodeForGameObjects()
        {
            Packages.Install(new[] {
                "com.unity.netcode.gameobjects"
                , "com.unity.multiplayer.tools" });
        }
    }
}