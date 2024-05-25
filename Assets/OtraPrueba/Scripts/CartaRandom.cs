using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartaRandom : MonoBehaviour
{
    public GameObject controler;
    public void cartaRandom()
    {
        //int randompersona = Random.Range(0, gameObject.GetComponent<CartasManager>().listaCartas.Count);
        controler.GetComponent<AssignSOB>().cartaInfo = gameObject.GetComponent<CartasManager>().listaCartas[Random.Range(0, gameObject.GetComponent<CartasManager>().listaCartas.Count)].ArmasSOB[Random.Range(0, 8)];
        controler.GetComponent<AssignSOB>().Asignartodo();
    }
}
