using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio4F2 : MonoBehaviour
{
    public GameObject Fase2D4Panel;

    void Start()
    {
        Fase2D4Panel.SetActive(false);

    }

    public void ShowFase2D4Panel()
    {
        Fase2D4Panel.SetActive(true);
    }
    public void HideFase2D4Panel()
    {
        Fase2D4Panel.SetActive(false);
    }
}
