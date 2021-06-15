using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio23F4 : MonoBehaviour
{
    public GameObject Fase4D23Panel;

    void Start()
    {
        Fase4D23Panel.SetActive(false);

    }

    public void ShowFase4D23Panel()
    {
        Fase4D23Panel.SetActive(true);
    }
    public void HideFase4D23Panel()
    {
        Fase4D23Panel.SetActive(false);
    }
}
