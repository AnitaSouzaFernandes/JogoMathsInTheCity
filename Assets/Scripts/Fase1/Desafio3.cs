using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio3 : MonoBehaviour
{
    public GameObject Fase1D3Panel;

    void Start()
    {
        Fase1D3Panel.SetActive(false);
    }

    public void ShowFase1D3Panel()
    {
        Fase1D3Panel.SetActive(true);
    }
    public void HideFase1D3Panel()
    {
        Fase1D3Panel.SetActive(false);
    }
}
