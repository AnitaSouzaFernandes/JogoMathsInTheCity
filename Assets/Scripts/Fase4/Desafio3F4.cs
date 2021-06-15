using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio3F4 : MonoBehaviour
{
    public GameObject Fase4D3Panel;

    void Start()
    {
        Fase4D3Panel.SetActive(false);

    }

    public void ShowFase4D3Panel()
    {
        Fase4D3Panel.SetActive(true);
    }
    public void HideFase4D3Panel()
    {
        Fase4D3Panel.SetActive(false);
    }
}
