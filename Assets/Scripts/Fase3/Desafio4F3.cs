using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio4F3 : MonoBehaviour
{
    public GameObject Fase3D4Panel;

    void Start()
    {
        Fase3D4Panel.SetActive(false);

    }

    public void ShowFase3D4Panel()
    {
        Fase3D4Panel.SetActive(true);
    }
    public void HideFase3D4Panel()
    {
        Fase3D4Panel.SetActive(false);
    }
}
