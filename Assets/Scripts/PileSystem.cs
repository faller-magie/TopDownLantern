using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PileSystem : MonoBehaviour
{
    public TextMesh pileText;
    public TextMesh timerText;

    private int pile;
    public float timer;

    public float pileDuration;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;
        pileText.text=((int)(timer/pileDuration)+1).ToString();
        timerText.text=(timer).ToString();
    }

    public void PickUpPile(GameObject g)
    {
        timer+=pileDuration;
        Debug.Log("pile récupéré !"); 
    }
}
