using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonInvisivel : MonoBehaviour
{
    public GameObject FasesPanel;
    public Button Invisivel;
    public GameObject ControleTextosTF;


    void Start()
    {
        FasesPanel.SetActive(false);
    }

    public void ShowFasesPanel()
    {
        FasesPanel.SetActive(true);
        Invisivel.interactable = true;
        ControleTextosTF.GetComponent<AbreTexto1>().MostraMensagem();
    }
    public void HideFasesPanel()
    {
        FasesPanel.SetActive(false);

    }
}
