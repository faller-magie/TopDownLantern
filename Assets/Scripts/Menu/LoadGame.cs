using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadGame : MonoBehaviour
{
    [SerializeField] private string SceneName;
    [SerializeField] private GameObject sceneToLoad;


    public void LoadSceneJeu()
    {
        SceneManager.LoadScene("Jeu");

        StartCoroutine(LoadScreenCoroutine());
    }
    
    IEnumerator LoadScreenCoroutine()
    {
        var ecran = Instantiate(sceneToLoad);
        DontDestroyOnLoad(ecran);

        /*var chargement = SceneManager.LoadSceneJeu("Jeu");
        while (chargement.isDone == false)
        {
            if (chargement.progress >= 1f)
            {
                chargement.allowSceneactivation = true;
                // disparition image
            }*/

            yield return new WaitForSeconds(2);
       // yield return null;
    
    

    }
}