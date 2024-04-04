
using System.IO;
using UnityEngine;


namespace Holypastry.Bakery.Editor
{

    public static class Folders
    {
        public static void Create(string root, params string[] folders)
        {
            string fullpath = Path.Combine(Application.dataPath, root);
            foreach (string folder in folders)
            {
                string path = Path.Combine(fullpath, folder);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
        }
    }

}