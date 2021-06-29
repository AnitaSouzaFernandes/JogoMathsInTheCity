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
    public Sprite VozOn;
    public Sprite VozOff;
    public Button button;
    public Button btn;

    public GameObject Texto1;
    public float tempo;
    private bool check;


    public void Update()
    {
        if (Time.time >= tempo && check == true)
        {
            Texto1.SetActive(true);
            check = false;
        }
    }

    void Start()
    {

        MenuPanel.SetActive(false);
        //Som.interactable = true;
        //Voz.interactable = true;
    }

    public void ShowMenuPanel()
    {
        tempo = Time.time + 1;
        Texto1.SetActive(false);
        check = true;
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
            btn.image.sprite = VozOn;
            //Voz.interactable = true;
        }
        else
        {
            PlayerPrefs.SetInt("Voz", 1);
            btn.image.sprite = VozOff;
            //Voz.interactable = false;
        }
    }
}
