using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cinematic : MonoBehaviour
{

    public void LancementAnimation()
    {
        StartCoroutine(Cinematique());
    }

    IEnumerator Cinematique()
    {
        yield return new WaitForSeconds(4);

    }



        void Start()
    {

    }


    void Update()
    {
        
    }
}
