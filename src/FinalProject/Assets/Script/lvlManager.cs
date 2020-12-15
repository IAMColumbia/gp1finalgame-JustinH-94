using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlManager : MonoBehaviour
{
    public Camera mainCam;
    public Color startColor;
    public string startScene;
    public static string currentSceneColor;
    public PlayerCollide playerCol;
    public PlayerManager pm;
    public SpikedWall wall;
    // Start is called before the first frame update
    void Start()
    {
        currentSceneColor = startScene;
        mainCam.backgroundColor = startColor;
        setApples();
    }

    // Update is called once per frame
    void Update()
    {
        changeBackGround();
        SceneReset();
    }

    void setApples()
    {
        if (currentSceneColor == "black")
            WhiteAppleActive();
        if (currentSceneColor == "white")
            BlackAppleActive();
    }

    void changeBackGround()
    {
        if (Dimension_Switch.switched)
        {
            if (currentSceneColor == "black")
            {
                currentSceneColor = "white";
                mainCam.backgroundColor = Color.white;
                BlackAppleActive();
            }
            else if(currentSceneColor == "white")
            {
                currentSceneColor = "black";
                mainCam.backgroundColor = Color.black;
                WhiteAppleActive();
            }
            Dimension_Switch.switched = false;
        }
    }

    void BlackAppleActive()
    {
        for (int i = 0; i < playerCol.BlackAppleArr.Count; i++)
        {
            playerCol.BlackAppleArr[i].SetActive(true);
        }
        for (int i = 0; i < playerCol.WhiteAppleArr.Count; i++)
        {
            playerCol.WhiteAppleArr[i].SetActive(false);
        }
    }

    void WhiteAppleActive()
    {
        for (int i = 0; i < playerCol.BlackAppleArr.Count; i++)
        {
            playerCol.BlackAppleArr[i].SetActive(false);
        }
        for (int i = 0; i < playerCol.WhiteAppleArr.Count; i++)
        {
            playerCol.WhiteAppleArr[i].SetActive(true);
        }
    }

    public void SceneReset()
    {
        if (PlayerCollide.PlayerDead)
        {
            pm.Respawn();
            Start();
            PlayerManager.AppleCount = 0;
            if (!SwitchLvl.isTutorial)
            {
                PlayerManager.PlayerLives--;
            }
            if (SwitchLvl.isFinalLvl)
            {
                wall.PositionReset();
            }
            PlayerCollide.PlayerDead = false;
        }
        
    }
}
