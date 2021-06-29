using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbreTexto10 : MonoBehaviour
{

    public GameObject Texto10;


    void Start()
    {
        
            Texto10.SetActive(false);

    }
    public void ShowTexto10Image()
    {
        Texto10.SetActive(true);
    }

    public void HideTexto10Image()
    {
        Texto10.SetActive(false);
    }
}
