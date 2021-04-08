using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPile : MonoBehaviour
{
    public PileSystem pileSystem;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Pile")
        {
            pileSystem.PickUpPile();
            Destroy(other.gameObject);
        }
    }
}
