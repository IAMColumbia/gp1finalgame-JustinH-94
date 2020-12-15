using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikedWallCollision : MonoBehaviour
{
    public GameObject sw;
    public bool hitWall;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == sw)
        {
            Debug.Log("He");
            hitWall = true;
        }
    }
}
