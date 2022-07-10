using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchManager : MonoBehaviour
{
    public GameObject NA, H, Li, Na, K, Rb, Cs, Fr;

    int shell, valence;
    public Text shellText, valenceText;
    
    // Start is called before the first frame update
    public void IncrementShell()
    {
        if(shell<8)
        {
            shell++;
            shellText.text = ""+shell;
        }
    }

    public void DecrementShell()
    {
        if(shell>0)
        {
            shell--;
            shellText.text = ""+shell;
        }
    }

    public void IncrementValence()
    {
        if(valence<18)
        {
            valence++;
            valenceText.text = ""+valence;
        }
    }

    public void DecrementValence()
    {
        if(valence>0)
        {
            valence--;
            valenceText.text = ""+valence;
        }
    }

    void Update() 
    {
        if(shell==1 && valence==1)
        {
            NA.SetActive(false);
            H.SetActive(true);
        }

        else if(shell==1 && valence==2)
        {
            NA.SetActive(false);
            Li.SetActive(true);
        }

        else if(shell==1 && valence==3)
        {
            NA.SetActive(false);
            Na.SetActive(true);
        }

        else if(shell==1 && valence==4)
        {
            NA.SetActive(false);
            K.SetActive(true);
        }

        else if(shell==1 && valence==5)
        {
            NA.SetActive(false);
            Rb.SetActive(true);
        }

        else if(shell==1 && valence==6)
        {
            NA.SetActive(false);
            Cs.SetActive(true);
        }
        
        else if(shell==1 && valence==7)
        {
            NA.SetActive(false);
            Rb.SetActive(true);
        }

        else
            NA.SetActive(true);
    }
}
