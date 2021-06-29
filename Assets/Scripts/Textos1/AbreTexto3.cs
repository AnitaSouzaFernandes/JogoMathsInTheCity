using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreTexto3 : MonoBehaviour
{
    public GameObject Texto3;

    void Start()
    {
        Texto3.SetActive(false);
    }

    public void ShowTexto3Image()
    {
        Texto3.SetActive(true);
    }

    public void HideTexto3Image()
    {
        Texto3.SetActive(false);
    }
}
