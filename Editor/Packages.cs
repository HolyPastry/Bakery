using UnityEditor;
using UnityEngine;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.Requests;
using System.Collections.Generic;


namespace Holypastry.Bakery.Editor
{
    public static class Packages
    {
        static AddRequest _addRequest;
        static readonly Queue<string> _packages = new();

        static RemoveRequest _removeRequest;

        public static void Install(string[] packageNames)
        {
            foreach (string packageName in packageNames)
            {
                _packages.Enqueue(packageName);
            }

            if (_packages.Count == 0) return;
            _addRequest = Client.Add(_packages.Dequeue());
            EditorApplication.update += InstallProgress;
        }

        public static void Uninstall(string[] packageNames)
        {
            foreach (string packageName in packageNames)
            {
                _packages.Enqueue(packageName);
            }

            if (_packages.Count == 0) return;
            _removeRequest = Client.Remove(_packages.Dequeue());
            EditorApplication.update += UninstallProgress;
        }

        private static void InstallProgress()
        {
            if (!_addRequest.IsCompleted) return;

            if (_addRequest.Status == StatusCode.Success)
                Debug.Log("Installed " + _addRequest.Result.packageId);

            if (_addRequest.Status >= StatusCode.Failure)
            {
                Debug.Log("Failed to install Package" + _addRequest.Error.message);
            }


            if (_packages.Count > 0)
                _addRequest = Client.Add(_packages.Dequeue());
            else
                EditorApplication.update -= InstallProgress;

        }

        private static void UninstallProgress()
        {

            if (!_removeRequest.IsCompleted) return;

            if (_removeRequest.Status == StatusCode.Success)
                Debug.Log("Removed " + _removeRequest.PackageIdOrName);

            if (_removeRequest.Status >= StatusCode.Failure)
                Debug.Log("Failed to remove " + _removeRequest.PackageIdOrName);

            if (_packages.Count > 0)
                _removeRequest = Client.Remove(_packages.Dequeue());
            else
                EditorApplication.update -= UninstallProgress;

        }
    }
}