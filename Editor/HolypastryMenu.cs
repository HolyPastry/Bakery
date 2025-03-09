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
    }
}