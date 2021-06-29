using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreTexto7 : MonoBehaviour
{
    public GameObject Texto7;

    void Start()
    {
        Texto7.SetActive(false);
    }

    public void ShowTexto7Image()
    {
        Texto7.SetActive(true);
    }

    public void HideTexto7Image()
    {
        Texto7.SetActive(false);
    }
}
