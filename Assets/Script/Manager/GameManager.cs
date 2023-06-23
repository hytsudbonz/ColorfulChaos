using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject soundBG;
    [SerializeField] GameObject menuBG;
    private GameManager gameManager;
    public GameManager Gamemanager { get;}

    private void Awake()
    {
        if(gameManager == null)
        {
            gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void LoadGameplayScene()
    {
        SceneManager.LoadScene(1);
    }
}
