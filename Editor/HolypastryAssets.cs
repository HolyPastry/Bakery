using UnityEditor;

namespace Holypastry.Bakery.Editor
{
    public static class HolypastryAssets
    {

        [MenuItem("Bakery/Install/Assets/OutlineMaterial")]
        public static void InstalOutlineMaterial()
        {
            Assets.ImportFromLocal("OutlineMaterial");
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


        [MenuItem("Bakery/Install/Assets/Prototype Materials")]
        public static void InstallPrototypeMaterials()
        {
            Assets.ImportFromStore("Grid Prototype Materials", "MLAgent", "Textures Materials");
        }

    }
}