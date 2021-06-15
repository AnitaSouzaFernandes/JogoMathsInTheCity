using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio22F4 : MonoBehaviour
{
    public GameObject Fase4D22Panel;

    void Start()
    {
        Fase4D22Panel.SetActive(false);

    }

    public void ShowFase4D22Panel()
    {
        Fase4D22Panel.SetActive(true);
    }
    public void HideFase4D22Panel()
    {
        Fase4D22Panel.SetActive(false);
    }
}
