using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio5F4 : MonoBehaviour
{
    public GameObject Fase4D5Panel;

    void Start()
    {
        Fase4D5Panel.SetActive(false);

    }

    public void ShowFase4D5Panel()
    {
        Fase4D5Panel.SetActive(true);
    }
    public void HideFase4D5Panel()
    {
        Fase4D5Panel.SetActive(false);
    }
}
