using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotation : MonoBehaviour
{
    float moveSpeed =2f;
    float waitTime;
    public Transform[] platformDestinations;
    public float initialTime;
    int destinationIndex = 0;

    //GameObject Platform1 = GameObject.Find("WhitePlatform");
    // Start is called before the first frame update
    void Start()
    {
        waitTime = initialTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, platformDestinations[destinationIndex].position, moveSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, platformDestinations[destinationIndex].position) <= 0.001f)
        {
            if (waitTime <= 0)
            {
                destinationIndex++;
                Start();
            }
            else
                waitTime -= Time.deltaTime;
            
            if(destinationIndex >= platformDestinations.Length)
            {
                destinationIndex = 0;
            }
        }
    }
}
