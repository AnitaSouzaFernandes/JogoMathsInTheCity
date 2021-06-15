using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio3F3 : MonoBehaviour
{
    public GameObject Fase3D3Panel;

    void Start()
    {
        Fase3D3Panel.SetActive(false);

    }

    public void ShowFase3D3Panel()
    {
        Fase3D3Panel.SetActive(true);
    }
    public void HideFase3D3Panel()
    {
        Fase3D3Panel.SetActive(false);
    }
}
