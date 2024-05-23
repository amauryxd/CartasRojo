using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

    public Camera mainCam;
    public float power;
   
       
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Ray mouseRay = mainCam.ScreenPointToRay(mouse);
        float middlePoint = (transform.position - mainCam.transform.position).magnitude * 0.5f;
        transform.LookAt(-mouseRay.origin + mouseRay.direction * middlePoint * power);
    }
}
