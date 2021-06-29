using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarregaTelaFases : MonoBehaviour
{
    public GameObject FasesPanel;


    void Start()
    {
        FasesPanel.SetActive(false);
    }

    public void ShowFasesPanel()
    {
        FasesPanel.SetActive(true);
    }
    public void HideFasesPanel()
    {
        FasesPanel.SetActive(false);
                  
    }
}
