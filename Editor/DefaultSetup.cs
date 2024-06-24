using System.IO;
using UnityEditor;

namespace Holypastry.Bakery.Editor
{
    public static class DefaultSetup
    {

        [MenuItem("Holypastry/Default Setup")]
        public static void CreateDefaultFolder()
        {
            Folders.Create("_Project", "Animation", "Art", "Materials", "Prefabs", "Presets", "ScriptableObjects", "Scenes", "Scripts", "Settings");

            Packages.Install(new[]
            {
                "https://github.com/KyleBanks/scene-ref-attribute.git",
                "https://github.com/starikcetin/Eflatun.SceneReference.git#upm",
                "com.unity.cinemachine",
                "com.unity.textmeshpro",
                "com.unity.inputsystem",
            });
        }


        [MenuItem("Holypastry/Install/Features/InputManager")]
        public static void InstallInputManager()
        {
            Assets.ImportFromLocal("InputManager");
        }



        [MenuItem("Holypastry/Install/Features/MAST")]
        public static void InstallMast()
        {
            Assets.ImportFromLocal("MAST 1.5.1");
        }

        [MenuItem("Holypastry/Install/Features/NPCs")]
        public static void InstallNpcs()
        {
            Assets.ImportFromLocal("NPC");
        }

        [MenuItem("Holypastry/Install/Features/Easy Save")]
        public static void InstallEasySave()
        {
            Assets.ImportFromStore("Easy Save - The Complete Save Data Serializer System", "Moodkie", "Editor ExtensionsUtilities");
        }

        [MenuItem("Holypastry/Install/Assets/OutlineMaterial")]
        public static void InstalOutlineMaterial()
        {
            Assets.ImportFromLocal("OutlineMaterial");
        }


        [MenuItem("Holypastry/Install/Features/Dotween")]
        public static void InstallDotween()
        {
            Assets.ImportFromStore("DOTween HOTween v2", "Demigiant", "Editor ExtensionsAnimation");
        }

        [MenuItem("Holypastry/Install/Assets/Crosshairs")]
        public static void InstallCrosshairs()
        {
            Assets.ImportFromStore("Too Many Crosshairs", "Clean Shirt Labs", "Textures MaterialsIcons UI");
        }

        [MenuItem("Holypastry/Install/Assets/AudioEffects")]
        public static void InstallAudioEffects()
        {
            Assets.ImportFromStore("FREE Casual Game SFX Pack", "Dustyroom", "AudioSound FX");
        }

        [MenuItem("Holypastry/Install/Assets/Shapes")]
        public static void InstallShapes()
        {
            Assets.ImportFromStore("Shapes", "Freya Holmr", "Editor ExtensionsEffects");
        }


        [MenuItem("Holypastry/Install/Assets/Prototype Materials")]
        public static void InstallPrototypeMaterials()
        {
            Assets.ImportFromStore("Grid Prototype Materials", "MLAgent", "Textures Materials");
        }


        [MenuItem("Holypastry/Install/Features/Splines")]
        public static void InstallMLAgents()
        {
            Packages.Install(new[] { "com.unity.splines" });
        }

        [MenuItem("Holypastry/Install/Features/AI Navigation")]
        public static void InstallAINavigation()
        {
            Packages.Install(new[] { "com.unity.ai.navigation" });
        }

        //install netcode for gameobjects
        [MenuItem("Holypastry/Install/Features/Netcode for GameObjects")]
        public static void InstallNetcodeForGameObjects()
        {
            Packages.Install(new[] {
                "com.unity.netcode.gameobjects"
                , "com.unity.multiplayer.tools" });
        }
    }
}