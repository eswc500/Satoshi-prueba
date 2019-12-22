using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class CHANGE_ITEM : MonoBehaviour
{
   
    bool item_switch;
    int switch_id;

    public Image imagen_pri;
    public Image frame;
    public Image background;

    public Color[] item_color;
     int color_id;
    

    public Sprite arma;
    public Sprite item;
    public Sprite []item_pri;
     int itempri_id;


    public TextMeshProUGUI num;
    public TextMeshProUGUI nom;


    public string numero_show;
    public string nombre_show;


    // Start is called before the first frame update
    void Start()

    {
        switch_id = Random.Range(0, 2);
        if (switch_id == 1)
        { item_switch = true; }
        else { item_switch = false; }

        color_id = Random.Range(0, item_color.Length);
        background.GetComponent<Image>().color = item_color[color_id];


        itempri_id = Random.Range(0, item_pri.Length);
        imagen_pri.sprite = item_pri[itempri_id];

        nom.text = nombre_show;
        num.text = numero_show;


        if (item_switch == true) //si es arma
        {
            Debug.Log("arma");
            frame.sprite = arma;
            num.gameObject.SetActive(false);
        }

        else
        {
            Debug.Log("item");
            frame.sprite = item;
            num.gameObject.SetActive(true);

        }
    }

}
