﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void TryAgain()
    {
        PlayerManager.PlayerLives = 3;
        SceneManager.LoadScene("Level_1");    
    }

    public void Quit()
    {
        Application.Quit();
    }
}
