using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tela_Vitoria : MonoBehaviour
{
    public GameObject TelaVPanel;

    void Start()
    {
        TelaVPanel.SetActive(false);
    }

    public void ShowTelaVPanel()
    {
        TelaVPanel.SetActive(true);
    }

    public void HideTelaVPanel()
    {
        TelaVPanel.SetActive(false);
    }
}
