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
        SceneManager.LoadScene("MoveScene");

        StartCoroutine(LoadScreenCoroutine());
    }
    
    IEnumerator LoadScreenCoroutine()
    {
        var ecran = Instantiate(sceneToLoad);
        DontDestroyOnLoad(ecran);

        var chargement = SceneManager.LoadSceneAsync("MoveScene");
        while (chargement.isDone == false)
        {
            if (chargement.progress >= 1f)
            {
                chargement.allowSceneActivation = true;
                // disparition image
            }

            yield return new WaitForSeconds(2);
            yield return null;

        }

    }
}