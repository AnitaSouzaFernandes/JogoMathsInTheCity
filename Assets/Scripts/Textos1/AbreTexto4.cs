using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreTexto4 : MonoBehaviour
{
    public GameObject Texto4;

    void Start()
    {
        Texto4.SetActive(false);
    }

    public void ShowTexto4Image()
    {
        Texto4.SetActive(true);
    }

    public void HideTexto4Image()
    {
        Texto4.SetActive(false);
    }
}
