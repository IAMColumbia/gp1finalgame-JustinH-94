using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SwitchLvl : MonoBehaviour
{
    Scene currentScene;
    public static bool isTutorial;
    public static bool isFinalLvl;
    private void Start()
    {
        PlayerCollide.CollideDoor = false;
        currentScene = SceneManager.GetActiveScene();
        Tutorial();
        FinalLvl();

    }

    void Tutorial()
    {
        if (currentScene.name == "Tutorial")
            isTutorial = true;
    }
    void FinalLvl()
    {
        if (currentScene.name == "Final_Level")
            isFinalLvl = true;
    }
    // Update is called once per frame
    void Update()
    {
        switchLvl();
        GameOver();
    }

    void GameOver()
    {
        if (PlayerManager.PlayerLives == 0)
        {
            isFinalLvl = false;
            SceneManager.LoadScene("EndState");
        }
    }

    void switchLvl()
    {
        if (PlayerCollide.CollideDoor)
        {
            if(currentScene.name == "Tutorial")
            {
                Level1();
            }
            if (currentScene.name == "Level_1")
            {
                Level2();
            }
            if(currentScene.name == "Level_2")
            {
                FinalLevel();
            }
            if (currentScene.name == "Final_Level")
            {
                EndGameScene();
            }
        }    
    }

    void Level1()
    {
        if (Input.GetKey("enter") || Input.GetKey("return"))
        {
            isTutorial = false;
            SceneManager.LoadScene("Level_1");  
        }     
    }

    void Level2()
    {
        if (Input.GetKey("enter") || Input.GetKey("return"))
        {
            SceneManager.LoadScene("Level_2");
        }
    }

    void FinalLevel()
    {
        if (Input.GetKey("enter") || Input.GetKey("return"))
        {
            SceneManager.LoadScene("Final_Level");
        }
    }

    void EndGameScene()
    {
        if (Input.GetKey("enter") || Input.GetKey("return"))
        {
            isFinalLvl = false;
            SceneManager.LoadScene("EndState");
        }
    }
}
