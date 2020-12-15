using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikedWall : MonoBehaviour
{
    Vector3 StartPosition;
    //Vector3 currentPos;

    public SpikedWallCollision spc;
    public Transform StopPoint;
    float spikeSpeed = 3.3f;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        //currentPos = StartPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, StopPoint.position, spikeSpeed * Time.deltaTime);
    }



    public void PositionReset()
    {
        transform.position = StartPosition;
    }
}
