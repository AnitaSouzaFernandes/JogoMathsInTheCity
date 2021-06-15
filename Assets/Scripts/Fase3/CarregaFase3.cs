using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarregaFase3 : MonoBehaviour
{
    public GameObject Fase3Panel;

    void Start()
    {
        Fase3Panel.SetActive(false);

    }

    public void ShowFase3Panel()
    {
        Fase3Panel.SetActive(true);
    }

    public void HideFase3Panel()
    {
        Fase3Panel.SetActive(false);
    }
}
