using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreTelaInicio : MonoBehaviour
{
    public GameObject TelaInicialPanel;


    void Start()
    {
        TelaInicialPanel.SetActive(true);
    }

    public void ShowTelaInicialPanel()
    {

            TelaInicialPanel.SetActive(true);
        
}
    public void HideTelaInicialPanel()
    {
        TelaInicialPanel.SetActive(false);
    }

}
