using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculoPontos : MonoBehaviour
{
   
    public int erros;
    public int acertos;

    public Text Acertos;
    public Text Erros;
    public Text Acertos2;
    public Text Erros2;


   /* public AudioSource src0;
    public AudioSource src1;
    public AudioSource src2;*/

    void Start()
    {
        erros = 0;
        acertos = 0;

    }

    public void acerto()
    {
        if (acertos == 0 || (acertos > 0 && acertos < 20))
        {
            acertos = acertos + 1;
            Acertos.text = acertos.ToString();
            Acertos2.text = acertos.ToString();

        }
        else if (acertos > 20)
        {
            acertos = 20;
            Acertos.text = acertos.ToString();
            Acertos2.text = acertos.ToString();

        }

    }


    public void erro()
    {
        erros = erros + 1;
        Erros.text = erros.ToString();
        Erros2.text = erros.ToString();

        /*if (erros == 0)
        {
            src0.Play(0);


        }
        else if (erros == 1)
        {
            src1.Play(0);

        }
        else if (erros == 2)
        {
            src2.Play(0);
        }*/
    }

}
