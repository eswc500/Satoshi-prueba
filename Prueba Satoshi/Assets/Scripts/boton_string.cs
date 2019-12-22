using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class boton_string : MonoBehaviour
{

    public TextMeshProUGUI texto;
    public static string txt_mostrar;

    // Start is called before the first frame update
    void Start()
    {
        texto.text = txt_mostrar;
    }

    
}
