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
        SceneManager.LoadScene("Jeu");

        StartCoroutine(LoadScreenCoroutine());
    }

    // IEnumerator LoadingScreenCoroutine()
    IEnumerator LoadScreenCoroutine()
    {
        //var prefab = Instantiate(loadingScreenPrefab);
        var ecran = Instantiate(sceneToLoad);

        //DontDestroyOnLoad(prefab);
        DontDestroyOnLoad(ecran);

        var chargement = SceneManager.LoadSceneAsync("Cinematic");
        while (chargement.isDone == false)
        {
            if (chargement.progress >= 1f)
            {
                chargement.allowSceneActivation = true;
                ecran = GetComponent<Animator>().SetTrigger("Disparition");
            }

            yield return new WaitForSeconds(2);
            yield return null;
        }
    }
}