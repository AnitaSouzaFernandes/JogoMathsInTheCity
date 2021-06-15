using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarregaFase2 : MonoBehaviour
{
    public GameObject Fase2Panel;

    void Start()
    {
        Fase2Panel.SetActive(false);

    }

    public void ShowFase2Panel()
    {
        Fase2Panel.SetActive(true);
    }
    public void HideFase2Panel()
    {
        Fase2Panel.SetActive(false);
    }
}

