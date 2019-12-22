using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class titulostr : MonoBehaviour
{
    public TextMeshProUGUI texto2;
    public static string txt_mostrar2;

    // Start is called before the first frame update
    void Start()
    {

        texto2.text = txt_mostrar2;
    }


}
