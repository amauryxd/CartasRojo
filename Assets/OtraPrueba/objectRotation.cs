using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectRotation : MonoBehaviour
{
    public float speed = 10f;
    public float idleSpeed = 0.05f;
    private bool isRotating = false;
    private float startMousePositionX;
    private float startMousePositionY;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isRotating = true;
            startMousePositionX = Input.mousePosition.x;
            startMousePositionY = Input.mousePosition.y;
            
        }else if (Input.GetMouseButtonUp(0))
        {
            isRotating = false;
        }

        if (isRotating)
        {
            float currentMousePosition = Input.mousePosition.x;
            float mouseMovement = currentMousePosition - startMousePositionX;

            float currentMousePositionY = Input.mousePosition.y;
            float mouseMovementY = currentMousePositionY - startMousePositionY;

            transform.Rotate(Vector3.up, -mouseMovement * speed * Time.deltaTime);
            startMousePositionX = currentMousePosition;

            transform.Rotate(Vector3.forward, mouseMovementY * speed * Time.deltaTime);
            startMousePositionY = currentMousePositionY;
        }
        else
        {
            gameObject.transform.rotation = new Quaternion(Mathf.Lerp(gameObject.transform.rotation.x, 0, idleSpeed), Mathf.Lerp(gameObject.transform.rotation.y, 0, idleSpeed), Mathf.Lerp(gameObject.transform.rotation.z, 0, idleSpeed), Mathf.Lerp(gameObject.transform.rotation.w, 1, idleSpeed));
        }
    }
}
