using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : MonoBehaviour
{
    [SerializeField] private Animator laserAnimator;
    [SerializeField] private AudioClip laserSFX;
    [SerializeField] private Transform raycastOrigin;
    [SerializeField] private GameController gameController;

    private AudioSource laserAudioSource;

    private RaycastHit hit;

    private void Awake()
    {
        laserAudioSource = GetComponent<AudioSource>();
        gameController = FindObjectOfType<GameController>();
    }

    public void LaserGunFired()
    {
        //count the number of shots fired
        gameController.UpdateShotsFired();

        //animate the gun
        laserAnimator.SetTrigger("Fire");

        //play laser gun SFX
        laserAudioSource.PlayOneShot(laserSFX);

        //raycast
        if (Physics.Raycast(raycastOrigin.position, raycastOrigin.forward, out hit, 800f))
        {
            /*
            if (hit.transform.GetComponent<AsteroidHit>() != null)
            {
                hit.transform.GetComponent<AsteroidHit>().AsteroidDestroyed();
            }
            */

            if (hit.transform.GetComponent<CoinDrop>() != null)
            {
                hit.transform.GetComponent<CoinDrop>().DropCoin();
            }
            else if (hit.transform.GetComponent<IRayCastInterface>() != null)
            {
                hit.transform.GetComponent<IRayCastInterface>().HitByRaycast();
            }

        }


    }


}
