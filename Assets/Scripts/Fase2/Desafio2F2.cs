using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio2F2 : MonoBehaviour
{
    public GameObject Fase2D2Panel;

    void Start()
    {
        Fase2D2Panel.SetActive(false);

    }

    public void ShowFase2D2Panel()
    {
        Fase2D2Panel.SetActive(true);
    }
    public void HideFase2D2Panel()
    {
        Fase2D2Panel.SetActive(false);
    }
}
