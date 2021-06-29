using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbreTexto1 : MonoBehaviour
{
    public GameObject Texto1;
    public GameObject Texto8;
    public GameObject Texto10;
    public GameObject Texto12;
    public GameObject Texto15;

    public Button Fase1;
    public Button Fase2;
    public Button Fase3;
    public Button Fase4;
    public Button Invisivel;

    public float tempo;
    private bool check;

    private void Start()
    {
        MostraMensagem();
 
    }

    public void Update()
    {
        if (Time.time >= tempo && check == true)
        {
            Texto1.SetActive(true);
            check = false;
        }
    }

    public void MostraMensagem()
    {

        if (Invisivel.interactable == true && Fase4.interactable == true && Fase3.interactable == true && Fase2.interactable == true && Fase1.interactable == true) {

            Texto1.SetActive(false);
            Texto8.SetActive(false);
            Texto10.SetActive(false);
            Texto12.SetActive(false);
            Texto15.SetActive(true);

        } else if (Fase4.interactable == true && Fase3.interactable == true && Fase2.interactable == true && Fase1.interactable == true)
        {
            Texto1.SetActive(false);
            Texto8.SetActive(false);
            Texto10.SetActive(false);
            Texto12.SetActive(true);
            Texto15.SetActive(false);

        }
        else if (Fase3.interactable == true && Fase2.interactable == true && Fase1.interactable == true)
        {
            Texto1.SetActive(false);
            Texto8.SetActive(false);
            Texto10.SetActive(true);
            Texto12.SetActive(false);
            Texto15.SetActive(false);

        }
        else if (Fase2.interactable == true && Fase1.interactable == true)
        {
            Texto1.SetActive(false);
            Texto8.SetActive(true);
            Texto10.SetActive(false);
            Texto12.SetActive(false);
            Texto15.SetActive(false);

        }
        else if (Fase1.interactable == true)
        {
            Texto1.SetActive(true);
            Texto8.SetActive(false);
            Texto10.SetActive(false);
            Texto12.SetActive(false);
            Texto15.SetActive(false);

        }
    }

    public void ShowTexto1Image()
    {

        tempo = Time.time + 0.5f;
        Texto1.SetActive(false);
        check = true;

    }

    public void HideTexto1Image()
    {
        Texto1.SetActive(false);
    }
}
