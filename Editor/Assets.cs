
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
    }

}