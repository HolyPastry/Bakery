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
            Directory.Delete("Scenes");
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
        [MenuItem("Holypastry/Remove Useless Stuff")]
        public static void RemoveUselessStuff()
        {

            Packages.Uninstall(new[]
            {
                "com.unity.visualscripting"
            });
        }


        [MenuItem("Holypastry/Install/Features/MAST")]
        public static void InstallMast()
        {
            Assets.ImportFromLocal("MAST 1.5.1");
        }

        [MenuItem("Holypastry/Install/Features/Proto NPCs")]
        public static void InstallNpcs()
        {
            Packages.Install(new[] {
                "https://github.com/KyleBanks/scene-ref-attribute.git",
                "https://github.com/starikcetin/Eflatun.SceneReference.git#upm",
                "git@github.com:HolyPastry/Bakery-NPC.git#upm" });
        }

        [MenuItem("Holypastry/Install/Features/Easy Save")]
        public static void InstallEasySave()
        {
            Assets.ImportFromStore("Easy Save - The Complete Save Data Serializer System", "Moodkie", "Editor ExtensionsUtilities");
        }

        // [MenuItem("Holypastry/Install/Algo/CollideAndSlide")]
        // public static void CollideAndSlide()
        // {
        //     Assets.ImportFromLocal("CollideAndSlide");
        // }

        // [MenuItem("Holypastry/Install/Feature/State Machine")]
        // public static void StateMachine()
        // {
        //     Assets.ImportFromLocal("StateMachine");
        // }

        // [MenuItem("Holypastry/Install Starter Kits/3D Platformer")]
        // public static void Install3DPlatformer()
        // {
        //     Assets.ImportFromLocal("3DPlatformer");
        // }

        // [MenuItem("Holypastry/Install Starter Kits/ShooterOnRails")]
        // public static void InstallShooterOnRails()
        // {
        //     Assets.ImportFromLocal("ShooterOnRails");
        // }

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