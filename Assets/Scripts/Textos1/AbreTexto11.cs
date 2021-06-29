using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreTexto11 : MonoBehaviour
{
    public GameObject Texto11;

    void Start()
    {
        Texto11.SetActive(false);
    }

    public void ShowTexto11Image()
    {
        Texto11.SetActive(true);
    }

    public void HideTexto11Image()
    {
        Texto11.SetActive(false);
    }
}
