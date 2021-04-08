using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    // Start is called before the first frame updat

  public GameObject key;


    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            key.SetActive(true);
            Destroy(gameObject);
        }
    }
}
