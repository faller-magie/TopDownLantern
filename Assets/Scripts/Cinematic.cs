using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Cinematic : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] private GameObject image;


    public void LoadSceneAsync()
    {
        StartCoroutine(Cinematique());
    }

    IEnumerator Cinematique()
    {
        var ecran = Instantiate(image);
        DontDestroyOnLoad(ecran);

        var chargement = SceneManager.LoadSceneAsync("Cinematique");
        chargement.allowSceneActivation = false;

        while (chargement.isDone == false)
        {
            if (chargement.progress >= 0.9f)
            {
                chargement.allowSceneActivation = true;
                ecran.GetComponent<Animator>().SetTrigger("Disparition");
            }

            yield return new WaitForSeconds(2);

        }

    }
}