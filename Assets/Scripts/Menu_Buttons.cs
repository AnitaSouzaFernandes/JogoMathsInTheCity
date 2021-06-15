using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Buttons : MonoBehaviour
{
    public GameObject MenuPanel;
    public Button Som;
    public Button Voz;
    public Sprite SomOn;
    public Sprite SomOff;
    public Button button;

    void Start()
    {
        MenuPanel.SetActive(false);
        //Som.interactable = true;
        //Voz.interactable = true;
    }

    public void ShowMenuPanel()
    {
        MenuPanel.SetActive(true);
    }

    public void HideMenuPanel()
    {
        MenuPanel.SetActive(false);
    }

    public void HabilitaSom()
    {
        if (PlayerPrefs.GetInt("Som") == 1)
        {
            PlayerPrefs.SetInt("Som", -1);
            Camera.main.GetComponent<AudioListener>().enabled = true;
            button.image.sprite = SomOn;
            //Som.interactable = true;         
        } 
        else
        {
            PlayerPrefs.SetInt("Som", 1);
            Camera.main.GetComponent<AudioListener>().enabled = false;
            button.image.sprite = SomOff;
            //Som.interactable = false;
        }
    }

    public void HabilitaVoz()
    {
        if (PlayerPrefs.GetInt("Voz") == 1)
        {
            PlayerPrefs.SetInt("Voz", -1);
            Voz.interactable = true;
        }
        else
        {
            PlayerPrefs.SetInt("Voz", 1);
            Voz.interactable = false;
        }
    }
}
