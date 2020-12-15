using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour
{
    public Camera mainCamera;
    Vector2 screenBound;
    float objWidth;
    float objHeight;
    static Vector3 bottomLeft;
    static Vector3 topRight;
    static Rect cameraRect;
    // Start is called before the first frame update
    void Start()
    {
        
        screenBound = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
        objWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x;
        objHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y;
        CameraRect();
    }

    void CameraRect()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(Vector3.zero);
        topRight = Camera.main.ScreenToWorldPoint(new Vector3(
            Camera.main.pixelWidth, Camera.main.pixelHeight));

        cameraRect = new Rect(
            bottomLeft.x,
            bottomLeft.y,
            topRight.x - bottomLeft.x,
            topRight.y - bottomLeft.y);
    }


    // Update is called once per frame
    void Update()
    {
        if (!SwitchLvl.isFinalLvl)
        {
            HitSideBound();
        }
        
        HitBottomBound();
    }
    void HitSideBound()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBound.x * -1 + objWidth, screenBound.x - objWidth);
        transform.position = viewPos;
    }

    void HitBottomBound()
    {
        if(transform.position.y <= cameraRect.yMin)
        {
            PlayerCollide.PlayerDead = true;
        }
    }
}
