using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio4F4 : MonoBehaviour
{
    public GameObject Fase4D4Panel;

    void Start()
    {
        Fase4D4Panel.SetActive(false);

    }

    public void ShowFase4D4Panel()
    {
        Fase4D4Panel.SetActive(true);
    }
    public void HideFase4D4Panel()
    {
        Fase4D4Panel.SetActive(false);
    }
}
