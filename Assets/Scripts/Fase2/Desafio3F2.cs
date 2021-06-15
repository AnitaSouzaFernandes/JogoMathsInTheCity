using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio3F2 : MonoBehaviour
{
    public GameObject Fase2D3Panel;

    void Start()
    {
        Fase2D3Panel.SetActive(false);

    }

    public void ShowFase2D3Panel()
    {
        Fase2D3Panel.SetActive(true);
    }
    public void HideFase2D3Panel()
    {
        Fase2D3Panel.SetActive(false);
    }
}
