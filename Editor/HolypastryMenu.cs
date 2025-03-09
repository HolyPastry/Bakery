using UnityEditor;
using UnityEngine;

namespace Holypastry.Bakery.Editor
{
    public static class HolypastryMenu
    {

        [MenuItem("Bakery/Open Persistent Data Path")]
        public static void OpenDataPath()
        {
            EditorUtility.RevealInFinder(Application.persistentDataPath);
        }

        [MenuItem("Bakery/Install/Features/Cheat Manager")]
        public static void InstallCheatManager()
        {
            Assets.ImportFromLocal("Cheat");
        }

        [MenuItem("Bakery/Install/Features/Flow Manager")]
        public static void InstallFlowManager()
        {
            Packages.Install(new[] { "https://github.com/HolyPastry/FlowServices.git" });
        }

        [MenuItem("Bakery/Install/Features/Google Sheets")]
        public static void InstallGoogleSheets()
        {
            Assets.ImportFromLocal("GoogleSheet");
        }

        [MenuItem("Bakery/Install/Features/TTS")]
        public static void InstallTTS()
        {
            Packages.Install(new[] { "https://github.com/HolyPastry/TextToSpeech.git" });
        }

        [MenuItem("Bakery/Install/Features/NPCs")]
        public static void InstallNpcs()
        {
            Assets.ImportFromLocal("NPC");
        }

        [MenuItem("Bakery/Install/Features/Inputs")]
        public static void InstallInput()
        {
            Assets.ImportFromLocal("Inputs");
        }

        [MenuItem("Bakery/Install/Features/BetterHierarchy")]

        public static void InstallBetterHierarchy()
        {
            Assets.ImportFromStore("Better Hierarchy", "Toaster Head", "Editor ExtensionsUtilities");
        }

        [MenuItem("Bakery/Install/Features/Easy Save")]
        public static void InstallEasySave()
        {
            Assets.ImportFromStore("Easy Save - The Complete Save Data Serializer System", "Moodkie", "Editor ExtensionsUtilities");
        }

        [MenuItem("Bakery/Install/Assets/OutlineMaterial")]
        public static void InstalOutlineMaterial()
        {
            Assets.ImportFromLocal("OutlineMaterial");
        }


        [MenuItem("Bakery/Install/Features/Dotween")]
        public static void InstallDotween()
        {
            Assets.ImportFromStore("DOTween HOTween v2", "Demigiant", "Editor ExtensionsAnimation");
        }

        [MenuItem("Bakery/Install/Features/Ink")]
        public static void InstallInk()
        {
            Packages.Install(new[] { "https://github.com/inkle/ink-unity-integration.git#upm" });
        }



        [MenuItem("Bakery/Install/Assets/Crosshairs")]
        public static void InstallCrosshairs()
        {
            Assets.ImportFromStore("Too Many Crosshairs", "Clean Shirt Labs", "Textures MaterialsIcons UI");
        }

        [MenuItem("Bakery/Install/Assets/AudioEffects")]
        public static void InstallAudioEffects()
        {
            Assets.ImportFromStore("FREE Casual Game SFX Pack", "Dustyroom", "AudioSound FX");
        }

        [MenuItem("Bakery/Install/Assets/Shapes")]
        public static void InstallShapes()
        {
            Assets.ImportFromStore("Shapes", "Freya Holmr", "Editor ExtensionsEffects");
        }


        [MenuItem("Bakery/Install/Assets/Prototype Materials")]
        public static void InstallPrototypeMaterials()
        {
            Assets.ImportFromStore("Grid Prototype Materials", "MLAgent", "Textures Materials");
        }


        [MenuItem("Bakery/Install/Features/Splines")]
        public static void InstallMLAgents()
        {
            Packages.Install(new[] { "com.unity.splines" });
        }

        [MenuItem("Bakery/Install/Features/AI Navigation")]
        public static void InstallAINavigation()
        {
            Packages.Install(new[] { "com.unity.ai.navigation" });
        }

        //install netcode for gameobjects
        [MenuItem("Bakery/Install/Features/Netcode for GameObjects")]
        public static void InstallNetcodeForGameObjects()
        {
            Packages.Install(new[] {
                "com.unity.netcode.gameobjects"
                , "com.unity.multiplayer.tools" });
        }
    }
}