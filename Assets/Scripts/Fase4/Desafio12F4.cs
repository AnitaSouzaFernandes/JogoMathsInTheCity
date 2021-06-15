using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio12F4 : MonoBehaviour
{
    public GameObject Fase4D12Panel;

    void Start()
    {
        Fase4D12Panel.SetActive(false);

    }

    public void ShowFase4D12Panel()
    {
        Fase4D12Panel.SetActive(true);
    }
    public void HideFase4D12Panel()
    {
        Fase4D12Panel.SetActive(false);
    }
}
