using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class open_popup : MonoBehaviour
{
    public string escena_nom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void seleccion()
    {

        SceneManager.LoadScene(escena_nom);
    
    }
}
