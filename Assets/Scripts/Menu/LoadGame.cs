using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadGame : MonoBehaviour
{
    [SerializeField] private string SceneName;
    public void LoadScene()
    {
        SceneManager.LoadScene("Jeu");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
