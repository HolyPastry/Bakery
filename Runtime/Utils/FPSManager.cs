using System;
using System.Collections;
using Holypastry;
using UnityEngine;


namespace Holypastry.Bakery
{
    public class FPSManager
    {
        [SerializeField] private int _targetFrameRate = 30;

        void Awake()
        {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = _targetFrameRate;

        }
    }
}
