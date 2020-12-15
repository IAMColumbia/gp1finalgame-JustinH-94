using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextScript : MonoBehaviour
{
    public TextMeshProUGUI enterDoor;
    public TextMeshProUGUI AppleCounter;
    public TextMeshProUGUI LivesCounter;
    public GameObject DoorText;
    public Dimension_Switch dSwitch;
    GameObject player;
    GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Door = GameObject.FindGameObjectWithTag("Door");
    }

    // Update is called once per frame
    void Update()
    {
        changeFontColor();
        if (PlayerCollide.CollideDoor)
        {
            enterDoor.text = "Press Enter";
        }
        else
        {
            enterDoor.text = "";
        }
        AppleCounter.text = "Apple(s) x" + PlayerManager.AppleCount;
        LivesCounter.text = "Live(s) x" + PlayerManager.PlayerLives;
    }

    void changeFontColor()
    {
        if (dSwitch.dSwitched)
        {
            if (lvlManager.currentSceneColor == "black")
            {
                enterDoor.color = Color.white;
                AppleCounter.color = Color.white;
                LivesCounter.color = Color.white;
            }
            else if(lvlManager.currentSceneColor == "white")
            {
                enterDoor.color = Color.black;
                AppleCounter.color = Color.black;
                LivesCounter.color = Color.black;
            }
        }
        
    }
}
