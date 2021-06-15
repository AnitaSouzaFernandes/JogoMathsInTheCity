using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarregaFase4 : MonoBehaviour
{
    public GameObject Fase4Panel;

    void Start()
    {
        Fase4Panel.SetActive(false);

    }

    public void ShowFase4Panel()
    {
        Fase4Panel.SetActive(true);
    }

    public void HideFase4Panel()
    {
        Fase4Panel.SetActive(false);
    }
}
