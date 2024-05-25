using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CartasManager : MonoBehaviour
{
    public List<ScriptableObjectContainer> listaCartas = new List<ScriptableObjectContainer>();
    public List<GameObject> controladoresCartas = new List<GameObject>();
    //cosas para checar lo del dropdown
    public TMP_Dropdown drop;
    // Start is called before the first frame update
    void Start()
    {
        Asignador();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Asignador()
    {
        controladoresCartas[0].GetComponent<AssignSOB>().cartaInfo = listaCartas[drop.value].ArmasSOB[0];
        controladoresCartas[0].GetComponent<AssignSOB>().Asignartodo();
        controladoresCartas[1].GetComponent<AssignSOB>().cartaInfo = listaCartas[drop.value].ArmasSOB[1];
        controladoresCartas[1].GetComponent<AssignSOB>().Asignartodo();
        controladoresCartas[2].GetComponent<AssignSOB>().cartaInfo = listaCartas[drop.value].ArmasSOB[2];
        controladoresCartas[2].GetComponent<AssignSOB>().Asignartodo();
        controladoresCartas[3].GetComponent<AssignSOB>().cartaInfo = listaCartas[drop.value].ArmasSOB[3];
        controladoresCartas[3].GetComponent<AssignSOB>().Asignartodo();
        controladoresCartas[4].GetComponent<AssignSOB>().cartaInfo = listaCartas[drop.value].ArmasSOB[4];
        controladoresCartas[4].GetComponent<AssignSOB>().Asignartodo();
        controladoresCartas[5].GetComponent<AssignSOB>().cartaInfo = listaCartas[drop.value].ArmasSOB[5];
        controladoresCartas[5].GetComponent<AssignSOB>().Asignartodo();
        controladoresCartas[6].GetComponent<AssignSOB>().cartaInfo = listaCartas[drop.value].ArmasSOB[6];
        controladoresCartas[6].GetComponent<AssignSOB>().Asignartodo();
        controladoresCartas[7].GetComponent<AssignSOB>().cartaInfo = listaCartas[drop.value].ArmasSOB[7];
        controladoresCartas[7].GetComponent<AssignSOB>().Asignartodo();
    }
}
