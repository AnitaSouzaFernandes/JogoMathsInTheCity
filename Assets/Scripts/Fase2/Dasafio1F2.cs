using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dasafio1F2 : MonoBehaviour
{
    public GameObject Fase2D1Panel;

    void Start()
    {
        Fase2D1Panel.SetActive(false);

    }

    public void ShowFase2D1Panel()
    {
        Fase2D1Panel.SetActive(true);
    }
    public void HideFase2D1Panel()
    {
        Fase2D1Panel.SetActive(false);
    }
}
