﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool paused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetKeyDown(KeyCode.Escape)){
    		if(paused){
    			Resume();
    		}
    		else{
    			Pause();
    		}
    	}
    }

    public void Resume(){
    	pauseMenuUI.SetActive(false);
    	Time.timeScale = 1f;
    	paused = false;
    }

    public void Pause(){
    	pauseMenuUI.SetActive(true);
    	Time.timeScale = 0f;
    	paused = true;
    }

    public void Menu(){
    	Time.timeScale = 1f;
    	SceneManager.LoadScene("MainMenu");
    }

    public void Quit(){
    	Application.Quit();
    }
}
