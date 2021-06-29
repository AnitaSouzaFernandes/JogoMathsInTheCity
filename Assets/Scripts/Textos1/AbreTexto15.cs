using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreTexto15 : MonoBehaviour
{
    public GameObject Texto15;

    void Start()
    {
        Texto15.SetActive(false);
    }

    public void ShowTexto15Image()
    {
        Texto15.SetActive(true);
    }

    public void HideTexto15Image()
    {
        Texto15.SetActive(false);
    }
}
