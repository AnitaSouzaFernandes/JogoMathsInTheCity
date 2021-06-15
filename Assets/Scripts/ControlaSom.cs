using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlaSom : MonoBehaviour
{
    void Start()
    {

        if (PlayerPrefs.GetInt("Som") == 1)
        {
            Camera.main.GetComponent<AudioListener>().enabled = true;

        }
        else
        {
            Camera.main.GetComponent<AudioListener>().enabled = false;

        }

    }

 }
