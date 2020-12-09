using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayController : MonoBehaviour
{
    Vector2 Walk;
    Vector2 Jump;
    GameObject start;
    Dimension_Switch dimension;
    Vector3 playerMove;
    float speed = 3f;
    bool isSwitched;
    Vector3 switchedPos; 

    // Start is called before the first frame update
    void Start()
    {
        dimension = GetComponent<Dimension_Switch>();
        start = GameObject.FindGameObjectWithTag("StartPosition");
        transform.position = start.transform.position;
        transform.localScale = new Vector3(1.8804f, 1.8804f, 1.8804f);
    }

    // Update is called once per frame
    void Update()
    {
        Walking();
        Jumping();
        //transform.position += playerMove*speed * Time.deltaTime;
    }

    void Walking()
    {
        if (Input.GetKey("left"))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey("right"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    void Jumping()
    {
        if (Input.GetKey("space"))
        {
            transform.position += Vector3.up *2* speed * Time.deltaTime;
        }
    }
}
