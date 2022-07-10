using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditorManager : MonoBehaviour
{
    public GameObject[] group1, group2, group17, group18;
     public GameObject Group1, Group2, Group17, Group18, NA;
    public int shell=0, valence=0;
    public Text shellText, valenceText;
    
    // Start is called before the first frame update
    public void IncrementShell()
    {
        if(shell<6)
        {
            shell++;
            shellText.text = ""+shell;
            Debug.Log(shell);
        }
    }

    public void DecrementShell()
    {
        if(shell>0)
        {
            shell--;
            shellText.text = ""+shell;
            Debug.Log(shell);
        }
    }

    public void IncrementValence()
    {
        if(valence<18)
        {
            valence++;
            valenceText.text = ""+valence;
            Debug.Log(valence);
        }
    }

    public void DecrementValence()
    {
        if(valence>0)
        {
            valence--;
            valenceText.text = ""+valence;
            Debug.Log(valence);
        }
    }

    void Update() 
    {
        if(valence == 1) // group-1
        {
            foreach (var item1 in group1)
            {  item1.SetActive(false); }

            foreach (var item2 in group2)
            {  item2.SetActive(false); }

            foreach (var item17 in group17)
            {  item17.SetActive(false); }

            foreach (var item18 in group18)
            {  item18.SetActive(false); }

            NA.SetActive(false); 

            group1[shell].SetActive(true);

            if(shell > 7)
                 NA.SetActive(true); 
        }

        else if(valence == 2) // group-2
        {
            foreach (var item1 in group1)
            {  item1.SetActive(false); }

            foreach (var item2 in group2)
            {  item2.SetActive(false); }

            foreach (var item17 in group17)
            {  item17.SetActive(false); }

            foreach (var item18 in group18)
            {  item18.SetActive(false); }

            NA.SetActive(false); 

            group2[shell].SetActive(true);

            if(shell > 6)
                 NA.SetActive(true); 
        }

        else if(valence == 17) // group-17
        {
            foreach (var item1 in group1)
            {  item1.SetActive(false); }

            foreach (var item2 in group2)
            {  item2.SetActive(false); }

            foreach (var item17 in group17)
            {  item17.SetActive(false); }

            foreach (var item18 in group18)
            {  item18.SetActive(false); }

            NA.SetActive(false); 

            group17[shell].SetActive(true);

            if(shell > 7)
                 NA.SetActive(true); 
        }

        else if(valence == 18) // group-17
        {
            foreach (var item1 in group1)
            {  item1.SetActive(false); }

            foreach (var item2 in group2)
            {  item2.SetActive(false); }

            foreach (var item17 in group17)
            {  item17.SetActive(false); }

            foreach (var item18 in group18)
            {  item18.SetActive(false); }

            NA.SetActive(false); 

            group18[shell].SetActive(true);

            if(shell > 7)
                 NA.SetActive(true); 
        }

        else
        {
            foreach (var item1 in group1)
            {  item1.SetActive(false); }

            foreach (var item2 in group2)
            {  item2.SetActive(false); }

            foreach (var item17 in group17)
            {  item17.SetActive(false); }

            foreach (var item18 in group18)
            {  item18.SetActive(false); }

            NA.SetActive(true);
        }
            
    }
}
