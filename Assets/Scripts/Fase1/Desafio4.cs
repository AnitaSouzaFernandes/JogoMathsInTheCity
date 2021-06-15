using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio4 : MonoBehaviour
{
    public GameObject Fase1D4Panel;

    void Start()
    {
        Fase1D4Panel.SetActive(false);
    }

    public void ShowFase1D4Panel()
    {
        Fase1D4Panel.SetActive(true);
    }
    public void HideFase1D4Panel()
    {
        Fase1D4Panel.SetActive(false);
    }
}
