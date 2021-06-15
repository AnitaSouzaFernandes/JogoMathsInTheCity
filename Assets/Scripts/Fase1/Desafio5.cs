using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio5 : MonoBehaviour
{
    public GameObject Fase1D5Panel;

    void Start()
    {
        Fase1D5Panel.SetActive(false);
    }

    public void ShowFase1D5Panel()
    {
        Fase1D5Panel.SetActive(true);
    }
    public void HideFase1D5Panel()
    {
        Fase1D5Panel.SetActive(false);
    }
}
