using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPile : MonoBehaviour
{
    public PileSystem pileSystem;

    void Start()
    {
       pileSystem.PickUpPile(gameObject);
    }
}
