using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationZ : MonoBehaviour
{
    public float velocidadRotacion = 50f;
    public bool rotarEnEjeX = false;
    public bool rotarEnEjeY = false;
    public bool rotarEnEjeZ = true;

    void Update()
    {
        if (rotarEnEjeX)
            transform.Rotate(velocidadRotacion * Time.deltaTime, 0f, 0f);
        if (rotarEnEjeY)
            transform.Rotate(0f, velocidadRotacion * Time.deltaTime, 0f);
        if (rotarEnEjeZ)
            transform.Rotate(0f, 0f, velocidadRotacion * Time.deltaTime);
    }
}
