using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchAtomManager : MonoBehaviour
{
    public GameObject Group1, NA, H, Li, Na, K, Rb, Cs, Fr; // Group 1
    public GameObject Group2, Be, Mg, Ca, Sr, Ba, Ra; // Group 2
    public GameObject Group7, F, Cl, Br, I, At, NC17; // Group 17
    public GameObject Group8, He, Ne, Ar, Kr, Xe, Rn, NC18; // Group 18

    public int shell=0, valence=0;
    public Text shellText, valenceText;
    
    // Start is called before the first frame update
    public void IncrementShell()
    {
        if(shell<8)
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
            Group1.SetActive(true);
            Group2.SetActive(false);
            Group7.SetActive(false);
            Group8.SetActive(false);
            if(shell==1) //hydrogen
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                Li.SetActive(false);
                H.SetActive(true);
            }

            else if(shell==2) //lithium
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                H.SetActive(false);
                Na.SetActive(false);
                Be.SetActive(false);
                Li.SetActive(true);
            }

            else if(shell==3) //sodium
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                Li.SetActive(false);
                K.SetActive(false);
                Ca.SetActive(false);
                Na.SetActive(true);
            }

            else if(shell==4) //potassium
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                Na.SetActive(false);
                Rb.SetActive(false);
                Ca.SetActive(false);
                K.SetActive(true);
            }

            else if(shell==5)//rubidium
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                K.SetActive(false);
                Cs.SetActive(false);
                Ba.SetActive(false);
                Rb.SetActive(true);
            }

            else if(shell==6)//cesium
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                Rb.SetActive(false);
                Fr.SetActive(false);
                Ba.SetActive(false);
                Cs.SetActive(true);
            }
            
            else if(shell==7)//francium
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                Cs.SetActive(false);
                Ra.SetActive(false);
                Fr.SetActive(true);
            }
        }

        else if(valence == 2) // group-2
        {
            Group2.SetActive(true);
            Group1.SetActive(false);
            Group7.SetActive(false);
            Group8.SetActive(false);
            if(shell==2) //beryllium
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                Li.SetActive(false);
                Mg.SetActive(false);
                H.SetActive(false);
                Be.SetActive(true);
            }

            else if(shell==3) //magnesium
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                Na.SetActive(false);
                Ca.SetActive(false);
                Be.SetActive(false);
                Mg.SetActive(true);
            }

            else if(shell==4) //calcium
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                Mg.SetActive(false);
                Sr.SetActive(false);
                K.SetActive(false);
                Ca.SetActive(true);
            }

            else if(shell==5) //strontium
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                Ca.SetActive(false);
                Ba.SetActive(false);
                Rb.SetActive(false);
                Sr.SetActive(true);
            }

            else if(shell==6) //radium
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                Ba.SetActive(false);
                Fr.SetActive(false);
                Ra.SetActive(true);
            }

            else
            {
                NA.SetActive(true);
                NC17.SetActive(false);
                Ba.SetActive(false);
                Fr.SetActive(false);
                Ra.SetActive(false);
            }
        }

        else if(valence == 17) // group-17  F, Cl, Br, I, At, NC17;
        {
            Group7.SetActive(true);
            Group2.SetActive(false);
            Group1.SetActive(false);
            Group8.SetActive(false);
            if(shell==2) //fluorine
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                At.SetActive(false);
                I.SetActive(false);
                Br.SetActive(false);
                Cl.SetActive(false);
                F.SetActive(true);
            }

            else if(shell==3) //chlorine
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                At.SetActive(false);
                I.SetActive(false);
                Br.SetActive(false);
                Cl.SetActive(true);
                F.SetActive(false);
            }

            else if(shell==4) //bromine
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                At.SetActive(false);
                I.SetActive(false);
                Br.SetActive(true);
                Cl.SetActive(false);
                F.SetActive(false);
            }

            else if(shell==5) //iodine
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                At.SetActive(false);
                I.SetActive(true);
                Br.SetActive(false);
                Cl.SetActive(false);
                F.SetActive(false);
            }

            else if(shell==6) //astatine
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                At.SetActive(true);
                I.SetActive(false);
                Br.SetActive(false);
                Cl.SetActive(false);
                F.SetActive(false);
            }

            else if(shell==7) 
            {
                NA.SetActive(false);
                NC17.SetActive(true);
                At.SetActive(false);
                I.SetActive(false);
                Br.SetActive(false);
                Cl.SetActive(false);
                F.SetActive(false);
            }

            else
            {
                NA.SetActive(true);
                At.SetActive(false);
                I.SetActive(false);
                Br.SetActive(false);
                Cl.SetActive(false);
                F.SetActive(false);
            }
        }

        else if(valence == 18) // group-18   He, Ne, Ar, Kr, Xe, Rn, NC18;
        {
            Group8.SetActive(true);
            Group2.SetActive(false);
            Group7.SetActive(false);
            Group1.SetActive(false);
            if(shell==1) //helium
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                Rn.SetActive(false);
                Xe.SetActive(false);
                Kr.SetActive(false);
                Ar.SetActive(false);
                Ne.SetActive(false);
                He.SetActive(true);
            }

             else if(shell==2) //neon
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                Rn.SetActive(false);
                Xe.SetActive(false);
                Kr.SetActive(false);
                Ar.SetActive(false);
                Ne.SetActive(true);
                He.SetActive(false);
            }

            else if(shell==3) //argon
            {NA.SetActive(false);
                NC17.SetActive(false);
                Rn.SetActive(false);
                Xe.SetActive(false);
                Kr.SetActive(false);
                Ar.SetActive(true);
                Ne.SetActive(false);
                He.SetActive(false);
            }

            else if(shell==4) //krypton
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                Rn.SetActive(false);
                Xe.SetActive(false);
                Kr.SetActive(true);
                Ar.SetActive(false);
                Ne.SetActive(false);
                He.SetActive(false);
            }

            else if(shell==5) //xenon
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                Rn.SetActive(false);
                Xe.SetActive(true);
                Kr.SetActive(false);
                Ar.SetActive(false);
                Ne.SetActive(false);
                He.SetActive(false);
            }

            else if(shell==6) //radon
            {
                NA.SetActive(false);
                NC17.SetActive(false);
                Rn.SetActive(true);
                Xe.SetActive(false);
                Kr.SetActive(false);
                Ar.SetActive(false);
                Ne.SetActive(false);
                He.SetActive(false);
            }

            else if(shell==7) 
            {
                NA.SetActive(false);
                NC17.SetActive(true);
                Rn.SetActive(false);
                Xe.SetActive(false);
                Kr.SetActive(false);
                Ar.SetActive(false);
                Ne.SetActive(false);
                He.SetActive(false);
               
            }

            else
            {
                NA.SetActive(true);
                Rn.SetActive(false);
                Xe.SetActive(false);
                Kr.SetActive(false);
                Ar.SetActive(false);
                Ne.SetActive(false);
                He.SetActive(false);
            }
        }

        else
        {
            Group1.SetActive(false);
            Group2.SetActive(false);
            Group7.SetActive(false);
            Group8.SetActive(false);
            NC17.SetActive(false);
            NA.SetActive(true);
        }
            
    }
}
