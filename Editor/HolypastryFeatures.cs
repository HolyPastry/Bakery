using UnityEditor;

namespace Holypastry.Bakery.Editor
{
    public static class HolypastryFeatures
    {
        [MenuItem("Bakery/Install/Features/BetterHierarchy")]

        public static void InstallBetterHierarchy()
        {
            Assets.ImportFromStore("Better Hierarchy", "Toaster Head", "Editor ExtensionsUtilities");
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

        [MenuItem("Bakery/Install/Features/Shapes")]
        public static void InstallShapes()
        {
            Assets.ImportFromStore("Shapes", "Freya Holmr", "Editor ExtensionsEffects");
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
    }
}