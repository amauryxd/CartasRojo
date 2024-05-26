using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinePointsAssigner : MonoBehaviour
{
    public LineRenderer linea;
    private Vector3[] puntos;
    public Transform punto1, punto2, punto3;

    // Start is called before the first frame update
    void Start()
    {
        linea = gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        puntos = new Vector3[] {
            punto1.position, punto2.position, punto3.position
        };
        linea.SetPositions(puntos);
    }
}
