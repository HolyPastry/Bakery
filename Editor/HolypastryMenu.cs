using UnityEditor;
using UnityEngine;

namespace Holypastry.Bakery.Editor
{
    public static class HolypastryMenu
    {


        [MenuItem("Holypastry/Open Persistent Data Path")]
        public static void OpenDataPath()
        {
            EditorUtility.RevealInFinder(Application.persistentDataPath);
        }

        [MenuItem("Holypastry/Install/Features/Cheat Manager")]
        public static void InstallCheatManager()
        {
            Assets.ImportFromLocal("Cheat");
        }

        [MenuItem("Holypastry/Install/Features/Flow Manager")]
        public static void InstallFlowManager()
        {
            Assets.ImportFromLocal("Flow");
        }

        [MenuItem("Holypastry/Install/Features/Google Sheets")]
        public static void InstallGoogleSheets()
        {
            Assets.ImportFromLocal("GoogleSheet");
        }

        [MenuItem("Holypastry/Install/Features/TTS")]
        public static void InstallTTS()
        {
            Packages.Install(new[] { "https://github.com/HolyPastry/TextToSpeech.git" });
        }

        [MenuItem("Holypastry/Install/Features/NPCs")]
        public static void InstallNpcs()
        {
            Assets.ImportFromLocal("NPC");
        }

        [MenuItem("Holypastry/Install/Features/Inputs")]
        public static void InstallInput()
        {
            Assets.ImportFromLocal("Inputs");
        }

        [MenuItem("Holypastry/Install/Features/BetterHierarchy")]

        public static void InstallBetterHierarchy()
        {
            Assets.ImportFromStore("Better Hierarchy", "Toaster Head", "Editor ExtensionsUtilities");
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

        [MenuItem("Holypastry/Install/Features/Ink")]
        public static void InstallInk()
        {
            Packages.Install(new[] { "https://github.com/inkle/ink-unity-integration.git#upm" });
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