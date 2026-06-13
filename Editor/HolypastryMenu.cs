using UnityEditor;
using UnityEngine;

namespace Bakery.Core.Editor
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