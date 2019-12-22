using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public GameObject Flash;
    public AudioSource gunfire;
    // Use this for initialization
    void Start()
    {
        gunfire = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalAmmo.LoadedAmmo >= 1)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                AudioSource gunsound = GetComponent<AudioSource>();
                gunsound.Play();
                Flash.SetActive(true);
                StartCoroutine(MuzzleOff());
                gunfire.Play();
                GetComponent<Animation>().Play("GunShot");
                GlobalAmmo.LoadedAmmo -= 1;
            }
        }
        IEnumerator MuzzleOff()
        {
            yield return new WaitForSeconds(0.1f);
            Flash.SetActive(false);
        }

    }
}
