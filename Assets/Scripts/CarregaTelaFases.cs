using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarregaTelaFases : MonoBehaviour
{
    public GameObject FasesPanel;
    //public GameObject Fase1D5Panel;
    //public GameObject Fase2D5Panel;
    //public GameObject Fase3D5Panel;
    //public GameObject Fase4D5Panel;

    //public Button Fase2;
    //public Button Fase3;
    //public Button Fase4;

    void Start()
    {
        FasesPanel.SetActive(false);
        //Fase2.interactable = false;
        //Fase3.interactable = false;
        //Fase4.interactable = false;
    }

    public void ShowFasesPanel()
    {
       // if (Fase1D5Panel == Canvas.previous)
       // {
        //    FasesPanel.SetActive(true);
        //    Fase2.interactable = true;
       // } else if(Fase1D5Panel != Canvas.previous && Fase2D5Panel == Canvas.previous)
       // {
       //     FasesPanel.SetActive(true);
       //     Fase2.interactable = true;
       //     Fase3.interactable = true;
       // }else if(Fase1D5Panel != Canvas.previous && Fase2D5Panel != Canvas.previous && Fase3D5Panel == Canvas.previous)
       // {
       //     FasesPanel.SetActive(true);
       //     Fase2.interactable = true;
       //     Fase3.interactable = true;
       //     Fase4.interactable = true;
       // }else{
            FasesPanel.SetActive(true);
       // }
    }
    public void HideFasesPanel()
    {
        FasesPanel.SetActive(false);
    }
}
