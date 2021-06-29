using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreTexto5 : MonoBehaviour
{
    public GameObject Texto5;

    void Start()
    {
        Texto5.SetActive(false);
    }

    public void ShowTexto5Image()
    {
        Texto5.SetActive(true);
    }

    public void HideTexto5Image()
    {
        Texto5.SetActive(false);
    }
}
