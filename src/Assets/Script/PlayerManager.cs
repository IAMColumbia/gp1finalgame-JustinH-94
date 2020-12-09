using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public enum State
    {
        white, black
    }
    State state;

    GameObject scene;
    lvlManager lvl;
    public Sprite startSprite;
    public Sprite WhiteSprite, BlackSprite;
    public static int PlayerLives = 3;
    public static int AppleCount;
    // Start is called before the first frame update
    void Start()
    {
        scene = GameObject.Find("Scene");
        lvl = scene.GetComponent<lvlManager>();
        //PlayerLives = 3;
        AppleCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentScene();
        //PlayerFell();
        switch(state)
        {
            case State.black:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = BlackSprite;
                break;
            case State.white:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = WhiteSprite;
                break;
        }
        
    }

    void CurrentScene()
    {
        if (lvlManager.currentSceneColor == "black")
            state = State.white;
        if (lvlManager.currentSceneColor == "white")
            state = State.black;
    }

    void PlayerFell()
    {
        if (Bound.playerFell)
        {
            PlayerLives--;
        }
    }
}
