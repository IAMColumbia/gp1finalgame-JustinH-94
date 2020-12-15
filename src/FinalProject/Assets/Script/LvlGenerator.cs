using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlGenerator : MonoBehaviour
{
    public List<GameObject> platformGen;
    int rand;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(0, platformGen.Count);
        Instantiate(platformGen[rand]);
    }

    // Update is called once per frame
    void Update()
    {
        //removeLvl();
    }

    void removeLvl()
    {
        if(PlayerCollide.CollideDoor && Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.KeypadEnter))
        {
            platformGen.RemoveAt(rand);
        }
    }
}
