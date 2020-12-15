using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollide : MonoBehaviour
{
    List<GameObject> RemovedBlackApple = new List<GameObject>();
    List<GameObject> RemovedWhiteApple = new List<GameObject>();

    public List<GameObject> BlackAppleArr;
    public List<GameObject> WhiteAppleArr;
    public GameObject BottomScreen;
    public GameObject SpikedWall;
    public static bool CollideDoor;
    public static bool CollideApple;
    public static bool PlayerDead = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        SpikedWallCol(collision);
        DoorCollision(collision);
        AppleCollision(collision);
        bottomCollision(collision);
    }

    void DoorCollision(Collider2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            CollideDoor = true;
        }
        else
        {
            CollideDoor = false;
        }
    }

    void AppleCollision(Collider2D collision)
    {
        for(int i = 0; i < BlackAppleArr.Count; i++)
        {
            if (collision.gameObject == BlackAppleArr[i])
            {
                RemovedBlackApple.Add(BlackAppleArr[i]);
                BlackAppleArr[i].SetActive(false);
                BlackAppleArr.RemoveAt(i);
                CollideApple = true;
            }
        }
        for (int i = 0; i < WhiteAppleArr.Count; i++)
        {
            if (collision.gameObject == WhiteAppleArr[i])
            {
                RemovedWhiteApple.Add(WhiteAppleArr[i]);
                WhiteAppleArr[i].SetActive(false);
                WhiteAppleArr.RemoveAt(i);
                CollideApple = true;
            }
        }
    }

    void bottomCollision(Collider2D collision)
    {
        if(collision.gameObject==BottomScreen || PlayerDead)
        {
            for (int i = 0; i < RemovedBlackApple.Count; i++)
            {
                BlackAppleArr.Add(RemovedBlackApple[i]);
            }
            for (int i = 0; i < RemovedWhiteApple.Count; i++)
            {
                WhiteAppleArr.Add(RemovedWhiteApple[i]);
            }
            RemovedWhiteApple.Clear();
            RemovedBlackApple.Clear();
        }
    }

    void SpikedWallCol(Collider2D collision)
    {
        if(collision.gameObject == SpikedWall)
        {
            PlayerDead = true;
        }
    }
}
