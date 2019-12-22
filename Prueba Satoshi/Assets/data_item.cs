using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class data_item : MonoBehaviour
{
    int itemid;
    public Image frame;
    public GameObject[] obj;
    public Sprite slot;

    
    // Start is called before the first frame update
    void Start()
    {
        itemid = Random.Range(0, 2);

        if (itemid != 1)
        {
            obj[0].SetActive(false);
            obj[1].SetActive(false);
            obj[2].SetActive(false);

            frame.sprite = slot;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
