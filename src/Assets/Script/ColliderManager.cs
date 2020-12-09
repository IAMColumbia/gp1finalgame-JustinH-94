using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        CollideApple();
    }

    void CollideApple()
    {
        if (PlayerCollide.CollideApple)
        {
            PlayerManager.AppleCount++;
            //GameObject.FindGameObjectWithTag("Apple").SetActive(false);
            PlayerCollide.CollideApple = false;
        }
    }
}
