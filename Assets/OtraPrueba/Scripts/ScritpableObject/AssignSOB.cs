using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AssignSOB : MonoBehaviour
{
    public ScriptableObjectCarta cartaInfo;

    public TextMeshProUGUI textNombre;
    public Image imgElemento1;
    public Image imgElemento2;
    public TextMeshProUGUI textNHablidad;
    public TextMeshProUGUI textDHabilidad;
    public TextMeshProUGUI textArmaDesc;
    public TextMeshProUGUI Nombre;
    public Material cartaMaterial;
    public GameObject RendererObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Asignartodo()
    {
        textNombre.text = cartaInfo.CartaNombre;
        imgElemento1.sprite = cartaInfo.Elemento;
        imgElemento2.sprite = cartaInfo.Elemento;
        textNHablidad.text = cartaInfo.HablidadNombre;
        textDHabilidad.text = cartaInfo.HablidadDescripcion;
        textArmaDesc.text = cartaInfo.ArmaDescripcion;
        Nombre.text = cartaInfo.NombrePersona;
        cartaMaterial.color = cartaInfo.CartaColor;
        //ahora instanciar el objeto
        if (RendererObj.transform.childCount != 0)
            Destroy(RendererObj.transform.GetChild(0).gameObject);  
        Instantiate(cartaInfo.ModeloArma, RendererObj.transform);
        
    }
}
