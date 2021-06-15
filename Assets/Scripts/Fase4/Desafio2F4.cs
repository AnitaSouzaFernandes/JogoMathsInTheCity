using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio2F4 : MonoBehaviour
{
    public GameObject Fase4D21Panel;

    void Start()
    {
        Fase4D21Panel.SetActive(false);

    }

    public void ShowFase4D21Panel()
    {
        Fase4D21Panel.SetActive(true);
    }
    public void HideFase4D21Panel()
    {
        Fase4D21Panel.SetActive(false);
    }
}
