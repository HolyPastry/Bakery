
using System.IO;
using UnityEngine;


namespace Holypastry.Bakery.Editor
{

    public static class Folders
    {
        public static void Create(string root, params string[] folders)
        {
            string rootPath = Path.Combine(Application.dataPath, root);
            if (!Directory.Exists(rootPath))
                Directory.CreateDirectory(rootPath);

            foreach (string folder in folders)
            {
                string path = Path.Combine(rootPath, folder);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
        }
    }

}