using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDownAssigner : MonoBehaviour
{
    public TMP_Dropdown dropd;
    private void Awake()
    {
        foreach (ScriptableObjectContainer sob in gameObject.GetComponent<CartasManager>().listaCartas)
        {
            dropd.options.Add(new TMP_Dropdown.OptionData(sob.NombreCrador));
        }
    }

}
