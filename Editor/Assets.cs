
using System.IO;
using UnityEditor;


namespace Holypastry.Bakery.Editor
{

    public static class Assets
    {
        public static void Import(string assetName, string subfolder, string folder = "~/Library/Unity/Asset Store-5.x")
        {
            AssetDatabase.ImportPackage(Path.Combine(folder, subfolder, assetName + ".unitypackage"), interactive: false);
        }

        public static void ImportFromStore(string assetName, params string[] subfolders)
        {
            string subfolder = Path.Combine(subfolders);
            Import(assetName, subfolder, "~/Library/Unity/Asset Store-5.x");
        }
    }

}