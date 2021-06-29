using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreTexto13 : MonoBehaviour
{
    public GameObject Texto13;

    void Start()
    {
        Texto13.SetActive(false);
    }

    public void ShowTexto13Image()
    {
        Texto13.SetActive(true);
    }

    public void HideTexto13Image()
    {
        Texto13.SetActive(false);
    }
}
