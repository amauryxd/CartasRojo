using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWeapons : MonoBehaviour
{
    // Speed of rotation
    public float rotationSpeedX = 1.0f, rotationSpeedY = 0.1f, rotationSpeedZ = 1.0f, maxAngleX = 45f, maxAngleZ = 45f;

    void Update()
    {
        // Calculate rotation amount
        float xRot = Time.deltaTime * rotationSpeedX;
        float zRot = Time.deltaTime * rotationSpeedZ;
        float yRot = Time.deltaTime * rotationSpeedY;
        // Apply rotation
        //transform.Rotate(new Vector3(xRot, yRot, zRot));
        Quaternion deltaRotation = Quaternion.Euler(xRot, yRot, zRot);
        transform.rotation *= deltaRotation;

        if (Mathf.Abs(transform.eulerAngles.x) > maxAngleX)
        {
            rotationSpeedX *= -1;
        }
        if (Mathf.Abs(transform.eulerAngles.z) > maxAngleZ)
        {
            rotationSpeedZ *= -1;
        }
    }
}
