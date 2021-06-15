using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio1F3 : MonoBehaviour
{
    public GameObject Fase3D1Panel;

    void Start()
    {
        Fase3D1Panel.SetActive(false);

    }

    public void ShowFase3D1Panel()
    {
        Fase3D1Panel.SetActive(true);
    }
    public void HideFase3D1Panel()
    {
        Fase3D1Panel.SetActive(false);
    }
}
