using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreTexto9 : MonoBehaviour
{
    public GameObject Texto9;

    void Start()
    {
        Texto9.SetActive(false);
    }

    public void ShowTexto9Image()
    {
        Texto9.SetActive(true);
    }

    public void HideTexto9Image()
    {
        Texto9.SetActive(false);
    }
}
