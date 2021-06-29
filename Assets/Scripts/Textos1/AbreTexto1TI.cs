using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbreTexto1TI : MonoBehaviour
{
    public GameObject Texto1;
    public float tempo;
    private bool check;

    void Start()
    {
        tempo = Time.time + 1;
        Texto1.SetActive(false);
        check = true;
    }

    public void Update()
    {
        if(Time.time >= tempo && check == true)
        {
            Texto1.SetActive(true);
            check = false;
        }
    }

    public void ShowTexto1Image()
    {

       Texto1.SetActive(true);
                     

    }

    public void HideTexto1Image()
    {
        Texto1.SetActive(false);
    }
}
