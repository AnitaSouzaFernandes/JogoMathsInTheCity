using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio5F2 : MonoBehaviour
{
    public GameObject Fase2D5Panel;

    void Start()
    {
        Fase2D5Panel.SetActive(false);

    }

    public void ShowFase2D5Panel()
    {
        Fase2D5Panel.SetActive(true);
    }
    public void HideFase2D5Panel()
    {
        Fase2D5Panel.SetActive(false);
    }
}
