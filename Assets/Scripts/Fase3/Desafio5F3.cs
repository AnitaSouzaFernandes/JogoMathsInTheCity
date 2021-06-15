using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio5F3 : MonoBehaviour
{
    public GameObject Fase3D5Panel;

    void Start()
    {
        Fase3D5Panel.SetActive(false);

    }

    public void ShowFase3D5Panel()
    {
        Fase3D5Panel.SetActive(true);
    }
    public void HideFase3D5Panel()
    {
        Fase3D5Panel.SetActive(false);
    }
}
