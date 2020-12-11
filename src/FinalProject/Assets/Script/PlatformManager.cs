using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    Collider2D col;
    GameObject scene;
    lvlManager lvl;
    public GameObject[] platformInvis;
    public GameObject[] changePlatColor;

    bool invisOn = false;
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
        InvisiblePlat();
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

    void InvisiblePlat()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            invisOn = true;
        if (invisOn)
        {
            for(int i = 0; i < platformInvis.Length; i++)
            {
                platformInvis[i].transform.position = new Vector3(transform.position.x, transform.position.y +100, transform.position.z);
            }
        }
    }
}
