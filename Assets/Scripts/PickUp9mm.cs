﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp9mm : MonoBehaviour
{

    public float TheDistance = PlayerCasting.DistanceFromTarget;
    public GameObject TextDisplay;

    public GameObject FakeGun;
    public GameObject RealGun;
    public GameObject AmmoDisplay;
    public AudioSource PickUpAudio;
    public GameObject ObjectiveComplete;
    public GameObject DoorStopper;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
        
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            TextDisplay.GetComponent<Text>().text = "Take 9mm Pistol";
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                StartCoroutine(TakeNineMil());
                ObjectiveComplete.SetActive(true);
            }
        }
    }

    void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }

    IEnumerator TakeNineMil()
    {
        PlayerPrefs.SetInt("TakenAGun",1);
        DoorStopper.SetActive(false);
        PickUpAudio.Play();
        transform.position = new Vector3(0, -1000, 0);
        FakeGun.SetActive(false);
        RealGun.SetActive(true);
        AmmoDisplay.SetActive(true);
        yield return new WaitForSeconds(0.1f);
    }

}
