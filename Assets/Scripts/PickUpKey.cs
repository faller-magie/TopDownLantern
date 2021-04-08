using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    // Start is called before the first frame updat

  public GameObject key;

    public SFXManager sfxbank;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            sfxbank.PlayKeySound();
            key.SetActive(true);
            Destroy(gameObject);
        }
    }
}
