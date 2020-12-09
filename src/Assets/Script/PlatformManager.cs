using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    Collider2D col;
    GameObject scene;
    lvlManager lvl;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
        scene = GameObject.Find("Scene");
        lvl = scene.GetComponent<lvlManager>();
    }

    // Update is called once per frame
    void Update()
    {
        setCollider();
    }

    void setCollider()
    {
        if(lvlManager.currentSceneColor=="black" && gameObject.tag == "BlackPlatform")
        {
            this.col.enabled = false;
        }
        else if(lvlManager.currentSceneColor == "black" && gameObject.tag == "WhitePlatform")
        {
            this.col.enabled = true;
        }
        if (lvlManager.currentSceneColor == "white" && gameObject.tag == "WhitePlatform")
        {
            this.col.enabled = false;
        }
        else if(lvlManager.currentSceneColor == "white" && gameObject.tag == "BlackPlatform")
        {
            this.col.enabled = true;
        }
    }
}
