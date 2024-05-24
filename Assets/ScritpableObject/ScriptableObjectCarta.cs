using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="NuevaArmaDespcricion(cambiarEsteNombre)", menuName ="Crear una nueva descripcion de arma")]
public class ScriptableObjectCarta : ScriptableObject
{
    [SerializeField] private string cartaNombre;
    [SerializeField] private Sprite elemento;
    [SerializeField] private string hablidadNombre;
    [SerializeField] private string hablidadDescripcion;
    [SerializeField] private string armaDescripcion;
    [SerializeField] private string nombrePersona;
    [SerializeField] private GameObject modeloArma;

    public string CartaNombre { get { return cartaNombre; } }
    public Sprite Elemento { get {return elemento; } }
    public string HablidadNombre { get { return hablidadNombre;} }
    public string HablidadDescripcion { get { return hablidadDescripcion; } }
    public string ArmaDescripcion { get { return armaDescripcion; }}
    public string NombrePersona { get {  return nombrePersona; }}
    public GameObject ModeloArma { get {  return modeloArma; }}

}
