using System.Collections;
using System.Collections.Generic;
// using DG.Tweening;
using UnityEngine;

namespace Holypastry.Bakery 
{
    [RequireComponent(typeof(AudioSource))]
    public class SpawnEffects : MonoBehaviour
    {
        [SerializeField] GameObject spawnVFX;
        [SerializeField] GameObject spawnSFX;

        //[SerializeField] float animationDuration = 2f;

        //
        void Start()
        {
            transform.localScale = Vector3.zero;
            //transform.DOScale(Vector3.one, animationDuration).SetEase(Ease.OutBounce);

            if (spawnSFX != null)
                Instantiate(spawnSFX, transform.position, Quaternion.identity);

            GetComponent<AudioSource>().Play();

        }

    }
}
