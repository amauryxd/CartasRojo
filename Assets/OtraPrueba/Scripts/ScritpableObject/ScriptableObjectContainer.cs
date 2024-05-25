using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ControladorDeCartas(cambiarEsteNombre)", menuName = "Crear Controlador de tus Cartas")]
public class ScriptableObjectContainer : ScriptableObject
{
    [SerializeField] private ScriptableObjectCarta[] armasSOB;
    [SerializeField] private string nombreCreador;

    public ScriptableObjectCarta[] ArmasSOB { get { return armasSOB; } }
    public string NombreCrador { get { return nombreCreador; } }
}
