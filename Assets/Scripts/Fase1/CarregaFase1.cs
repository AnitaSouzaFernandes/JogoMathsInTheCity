using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarregaFase1 : MonoBehaviour
{
    public GameObject Fase1Panel;

    void Start()
    {
        Fase1Panel.SetActive(false);

    }

    public void ShowFase1Panel()
    {
        Fase1Panel.SetActive(true);
    }
    public void HideFase1Panel()
    {
        Fase1Panel.SetActive(false);
    }
}
