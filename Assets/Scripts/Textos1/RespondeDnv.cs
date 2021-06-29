using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespondeDnv : MonoBehaviour
{
    public GameObject Pergunta;
   
    void Start()
    {
        Pergunta.SetActive(false);
    }

    public void ShowPergunta()
    {
        Pergunta.SetActive(true);
    }
    public void HidePergunta()
    {
        Pergunta.SetActive(false);
    }
}
