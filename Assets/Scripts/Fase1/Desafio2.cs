using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio2 : MonoBehaviour
{
    public GameObject Fase1D2Panel;

    void Start()
    {
        Fase1D2Panel.SetActive(false);
    }

    public void ShowFase1D2Panel()
    {
        Fase1D2Panel.SetActive(true);
    }
    public void HideFase1D2Panel()
    {
        Fase1D2Panel.SetActive(false);
    }
}
