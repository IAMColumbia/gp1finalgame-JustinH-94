using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Dimension_Switch : MonoBehaviour
{
    public static bool switched = false;
    public bool dSwitched = false;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left shift") && PlayerManager.AppleCount>0)
        {
            switched = true;
            dSwitched = switched;
            PlayerManager.AppleCount--;
        }
    }
}
