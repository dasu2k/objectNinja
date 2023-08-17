using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Canvas menu;
    public Button resumeButton;
    public Button restartButton;

    public bool isPaused = false;

    public void resume(){
        menu.gameObject.SetActive(!isPaused);
        isPaused=!isPaused;
        Time.timeScale = isPaused ? 0 : 1;
    }



    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            resume();
        }
    }
    
    public void onResumeClick(){
        resume();   
    }

    public void onRestartClick(){
        SceneManager.UnloadSceneAsync("Prototype 5");
        SceneManager.LoadScene("Prototype 5");
        
        resume();
    }
}
