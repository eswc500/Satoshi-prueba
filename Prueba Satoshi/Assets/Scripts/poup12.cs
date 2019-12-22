using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class poup12 : MonoBehaviour
{

    public bool switchpopup;
    public GameObject[] pop;
    public string[] boton_txt;
    public string[] tit_txt;

    public TextMeshProUGUI boton;
    public TextMeshProUGUI titulo;


    // Start is called before the first frame update
    void Start()
    {

        if (switchpopup == true)
        {
            pop[0].SetActive(true);
            boton.text = boton_txt[0];
            titulo.text = tit_txt[0];
            pop[1].SetActive(false);
            

        }

        else

        {
            pop[0].SetActive(false);
            boton.text = boton_txt[1];
            titulo.text = tit_txt[1];
            pop[1].SetActive(true);


        }

    }

    
}
