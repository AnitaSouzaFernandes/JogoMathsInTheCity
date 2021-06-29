using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbreTexto8 : MonoBehaviour
{

    public GameObject Texto8;


    void Start()
    {

        Texto8.SetActive(false);
    }
     
    public void ShowTexto8Image()
    {
        Texto8.SetActive(true);
    }

    public void HideTexto8Image()
    {
        Texto8.SetActive(false);
    }
}
