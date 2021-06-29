using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreTexto14 : MonoBehaviour
{
    public GameObject Texto14;

    void Start()
    {
        Texto14.SetActive(false);
    }

    public void ShowTexto14Image()
    {
        Texto14.SetActive(true);
    }

    public void HideTexto14Image()
    {
        Texto14.SetActive(false);
    }
}
