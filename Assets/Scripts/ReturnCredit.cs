using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnCredit : MonoBehaviour
{
    public GameObject open;
    public GameObject close;

    public void Return()
    {
        open.SetActive(true);
        close.SetActive(false);
    }
}