using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio1F4 : MonoBehaviour
{
    public GameObject Fase4D11Panel;

    void Start()
    {
        Fase4D11Panel.SetActive(false);

    }

    public void ShowFase4D11Panel()
    {
        Fase4D11Panel.SetActive(true);
    }
    public void HideFase4D11Panel()
    {
        Fase4D11Panel.SetActive(false);
    }
}
