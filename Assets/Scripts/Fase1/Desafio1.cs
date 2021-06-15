using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio1 : MonoBehaviour
{
    public GameObject Fase1D1Panel;

    void Start()
    {
        Fase1D1Panel.SetActive(false);

    }

    public void ShowFase1D1Panel()
    {
        Fase1D1Panel.SetActive(true);
    }
    public void HideFase1D1Panel()
    {
        Fase1D1Panel.SetActive(false);
    }
}
