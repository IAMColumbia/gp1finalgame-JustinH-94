using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SwitchLvl : MonoBehaviour
{
    Scene currentScene;
    public static bool isTutorial;
    private void Start()
    {
        PlayerCollide.CollideDoor = false;
        currentScene = SceneManager.GetActiveScene();
        Tutorial();
    }

    void Tutorial()
    {
        if (currentScene.name == "Tutorial")
            isTutorial = true;
    }
    // Update is called once per frame
    void Update()
    {
        switchLvl();
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
        }    
    }

    void Level1()
    {
        if (Input.GetKey("enter") || Input.GetKey("return"))
        {
            SceneManager.LoadScene("Level_1");
            isTutorial = false;
        }
            
    }

    void Level2()
    {
        if (Input.GetKey("enter") || Input.GetKey("return"))
        {
            SceneManager.LoadScene("Level_2");
            isTutorial = false;
        }
    }
}
