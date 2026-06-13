using UnityEngine;


namespace Bakery.Core
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
