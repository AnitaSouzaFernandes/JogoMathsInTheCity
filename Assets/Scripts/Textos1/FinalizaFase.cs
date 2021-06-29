using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalizaFase : MonoBehaviour
{
    public GameObject FasesPanel;
    public GameObject ControleTextosTF;
    public Button Fase2;
  

    void Start()
    {

        FasesPanel.SetActive(false);
        
    }

    public void ShowFasesPanel()
    {
        FasesPanel.SetActive(true);
        Fase2.interactable = true;
        ControleTextosTF.GetComponent<AbreTexto1>().MostraMensagem();

    }
    public void HideFasesPanel()
    {
        FasesPanel.SetActive(false);
    }
}
