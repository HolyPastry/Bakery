using UnityEditor;
using UnityEngine;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.Requests;
using System.Collections.Generic;


namespace Holypastry.Bakery.Editor
{
    public static class Packages
    {
        static AddRequest _request;
        static Queue<string> _packageToInstall = new();
        public static void Install(string[] packageNames)
        {
            foreach (string packageName in packageNames)
            {
                _packageToInstall.Enqueue(packageName);
            }

            if (_packageToInstall.Count == 0) return;
            _request = Client.Add(_packageToInstall.Dequeue());
            EditorApplication.update += ProgressRequest;

        }

        private static void ProgressRequest()
        {
            if (_request.IsCompleted)
            {
                if (_request.Status == StatusCode.Success)
                {
                    Debug.Log("Installed " + _request.Result.packageId);
                }
                else if (_request.Status >= StatusCode.Failure)
                {
                    Debug.Log("Failed to install " + _request.Result.packageId);
                }

                if (_packageToInstall.Count > 0)
                {
                    _request = Client.Add(_packageToInstall.Dequeue());
                }
                else
                {
                    EditorApplication.update -= ProgressRequest;
                }
            }
        }
    }
}