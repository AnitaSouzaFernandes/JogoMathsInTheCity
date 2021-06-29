using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbreTexto12 : MonoBehaviour
{

    public GameObject Texto12;


    void Start()
    {
       
            Texto12.SetActive(false);
        
    }

    public void ShowTexto12Image()
    {
        Texto12.SetActive(true);
    }

    public void HideTexto12Image()
    {
        Texto12.SetActive(false);
    }
}
