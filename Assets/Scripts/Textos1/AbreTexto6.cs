using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreTexto6 : MonoBehaviour
{
    public GameObject Texto6;

    void Start()
    {
        Texto6.SetActive(false);
    }

    public void ShowTexto6Image()
    {
        Texto6.SetActive(true);
    }

    public void HideTexto6Image()
    {
        Texto6.SetActive(false);
    }
}
