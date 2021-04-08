using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    private AudioSource[] sfxlist;

    private AudioSource pop;
    private AudioSource key;

    // Start is called before the first frame update
    void Start()
    {
        sfxlist = GetComponents<AudioSource>();

        pop = sfxlist[0];
        key = sfxlist[1];
    }

    // Update is called once per frame
   
   public void PlayPopSound()
   {
       pop.Play();
   }

   public void PlayKeySound()
   {
       key.Play();
   }
}
