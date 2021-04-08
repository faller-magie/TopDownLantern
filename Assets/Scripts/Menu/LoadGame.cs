using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadGame : MonoBehaviour
{
    [SerializeField] private string SceneName;
    [SerializeField] private GameObject sceneToLoad;


    public void LoadSceneAsync()
    {
        //SceneManager.LoadScene("MoveScene");

        StartCoroutine(LoadScreenCoroutine());
    }
    
    IEnumerator LoadScreenCoroutine()
    {
        var ecran = Instantiate(sceneToLoad);
        DontDestroyOnLoad(ecran);

        var chargement = SceneManager.LoadSceneAsync("Game");
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