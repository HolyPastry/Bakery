using UnityEditor;

namespace Holypastry.Bakery.Editor
{
    public static class DefaultSetup
    {

        [MenuItem("Holypastry/Default Setup")]
        public static void CreateDefaultFolder()
        {
            Folders.Create("_Project", "Animation", "Art", "Materials", "Prefabs", "Presets", "ScriptableObjects", "Scenes", "Scripts", "Settings");
            AssetDatabase.Refresh();

            Packages.Install(new[]
            {
                "https://github.com/KyleBanks/scene-ref-attribute.git",
                "https://github.com/starikcetin/Eflatun.SceneReference.git#upm",
                "com.unity.cinemachine",
                "com.unity.textmeshpro",
                "com.unity.inputsystem",
            });
        }

        [MenuItem("Holypastry/Install/MAST")]
        public static void InstallMast()
        {
            Assets.ImportFromLocal("MAST 1.5.1");
        }

        [MenuItem("Holypastry/Install Starter Kits/3D Platformer")]
        public static void Install3DPlatformer()
        {
            Assets.ImportFromLocal("3DPlatformer");
        }

        [MenuItem("Holypastry/Install Starter Kits/ShooterOnRails")]
        public static void InstallShooterOnRails()
        {
            Assets.ImportFromLocal("ShooterOnRails");
        }


        [MenuItem("Holypastry/Install/Dotween")]
        public static void InstallDotween()
        {
            Assets.ImportFromStore("DOTween HOTween v2", "Demigiant", "Editor ExtensionsAnimation");
        }

        [MenuItem("Holypastry/Install/Crosshairs")]
        public static void InstallCrosshairs()
        {
            Assets.ImportFromStore("Too Many Crosshairs", "Clean Shirt Labs", "Textures MaterialsIcons UI");
        }

        [MenuItem("Holypastry/Install/AudioEffects")]
        public static void InstallAudioEffects()
        {
            Assets.ImportFromStore("FREE Casual Game SFX Pack", "Dustyroom", "AudioSound FX");
        }

        [MenuItem("Holypastry/Install/Shapes")]
        public static void InstallShapes()
        {
            Assets.ImportFromStore("Shapes", "Freya Holmr", "Editor ExtensionsEffects");
        }


        [MenuItem("Holypastry/Install/Prototype Materials")]
        public static void InstallPrototypeMaterials()
        {
            Assets.ImportFromStore("Grid Prototype Materials", "MLAgent", "Textures Materials");
        }


        [MenuItem("Holypastry/Install/Splines")]
        public static void InstallMLAgents()
        {
            Packages.Install(new[] { "com.unity.splines" });
        }

        [MenuItem("Holypastry/Install/AI Navigation")]
        public static void InstallAINavigation()
        {
            Packages.Install(new[] { "com.unity.ai.navigation" });
        }

        //install netcode for gameobjects
        [MenuItem("Holypastry/Install/Netcode for GameObjects")]
        public static void InstallNetcodeForGameObjects()
        {
            Packages.Install(new[] {
                "com.unity.netcode.gameobjects"
                , "com.unity.multiplayer.tools" });
        }
    }
}