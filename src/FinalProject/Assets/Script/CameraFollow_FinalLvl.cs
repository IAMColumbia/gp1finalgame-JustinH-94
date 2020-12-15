using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow_FinalLvl : MonoBehaviour
{
    Transform playerPos;

    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 placeHolder = transform.position;
        placeHolder.x = playerPos.position.x;
        transform.position = placeHolder;
    }
}
