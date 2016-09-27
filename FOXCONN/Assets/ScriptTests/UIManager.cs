﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
    
{
    

    public GameObject PausePanel;

    public bool isPaused;


    void Start()
    {
        isPaused = false;

    }
    void Update(){
        if (isPaused){
            PauseGame(true);
            }
        else {
            PauseGame (false);
        }
        if(Input.GetButtonDown("Cancel"))
        {            
            SwitchPause();
        }

    }
    void PauseGame(bool state){
        if (state){
             Time.timeScale = 0.0f; //paused
        } else {
            Time.timeScale = 1.0f; //unpaused
            PausePanel.SetActive (state);
        }
        PausePanel.SetActive(state);
    }
    public void SwitchPause() {
        if (isPaused){
            isPaused = false; //Changes the value
            } else
        {
            isPaused = true;
        }
    }
}
