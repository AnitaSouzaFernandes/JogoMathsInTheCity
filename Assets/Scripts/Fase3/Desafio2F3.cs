using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio2F3 : MonoBehaviour
{
    public GameObject Fase3D2Panel;

    void Start()
    {
        Fase3D2Panel.SetActive(false);

    }

    public void ShowFase3D2Panel()
    {
        Fase3D2Panel.SetActive(true);
    }
    public void HideFase3D2Panel()
    {
        Fase3D2Panel.SetActive(false);
    }
}
