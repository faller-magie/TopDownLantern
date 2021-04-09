using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPile : MonoBehaviour
{
    public PileSystem pileSystem;

    //public SFXManager pop;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Pile")
        {

            GameObject.Find("Heros").GetComponent<PlayerController>().lightIntensity = GameObject.Find("Heros").GetComponent<PlayerController>().maxIntensity;
            pileSystem.PickUpPile();
            //pop.PlayPopSound();
            Destroy(other.gameObject);
        }
    }
}
