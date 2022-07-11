using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using Firebase.Firestore;
//using Firebase.Database;
//using Firebase.Extensions;

public class FirestoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText; 
    [SerializeField] TextMeshProUGUI groupText;
    [SerializeField] TextMeshProUGUI periodText;
    [SerializeField] TextMeshProUGUI stateText;
    [SerializeField] TextMeshProUGUI numText;
    [SerializeField] TextMeshProUGUI massText;
    [SerializeField] TextMeshProUGUI elecText;
    //FirebaseFirestore db;
    public Text shellText, valenceText;
    int shell, valence;
    public GameObject NA, elementPanel;

    public GameObject[] group1, group2, group17, group18;

    //DatabaseReference reference;
    
    public void Read_Data(string element)
    {
    //    reference.Child("Element").Child(element).GetValueAsync().ContinueWith(task =>
    //     {
    //         if(task.IsCompleted)
    //         {
    //             Debug.Log("Successful Read");
    //             DataSnapshot snapshot = task.Result;
    //             nameText.text = snapshot.Child("name").Value.ToString();
    //             groupText.text = snapshot.Child("group").Value.ToString();
    //             periodText.text = snapshot.Child("period").Value.ToString();
    //             stateText.text = snapshot.Child("state").Value.ToString();
    //             numText.text = snapshot.Child("num").Value.ToString();
    //             massText.text = snapshot.Child("mass").Value.ToString();
    //             elecText.text = snapshot.Child("elec").Value.ToString();
    //         }
    //     });
    }
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


    // Start is called before the first frame update
    void Start()
    {
        //db = FirebaseFirestore.DefaultInstance;
        //reference = FirebaseDatabase.DefaultInstance.RootReference;
        foreach (var item1 in group1)
        {  item1.SetActive(false); }

        foreach (var item2 in group2)
        { item2.SetActive(false); }

        foreach (var item17 in group17)
        { item17.SetActive(false); }

        foreach (var item18 in group18)
        { item18.SetActive(false); }
    }
    void Update() 
    {
        if(valence == 1)
        {
            elementPanel.SetActive(true);
            if(shell==1)
            {
                NA.SetActive(false);
                group1[0].SetActive(true);
                Read_Data("hydrogen");
            }

            else if(shell==2)
            {
                NA.SetActive(false);
                group1[1].SetActive(true);
                Read_Data("lithium");
            }

            else if(shell==3)
            {
                NA.SetActive(false);
                group1[2].SetActive(true);
                Read_Data("sodium");
            }

            else if(shell==4)
            {
                NA.SetActive(false);
                group1[3].SetActive(true);
                Read_Data("potassium");
            }

            else if(shell==4)
            {
                NA.SetActive(false);
                group1[4].SetActive(true);
                Read_Data("rubidium");
            }

            else if(shell==4)
            {
                NA.SetActive(false);
                group1[5].SetActive(true);
                Read_Data("cesium");
            }

            else
            {
                elementPanel.SetActive(false);
                foreach (var item1 in group1)
                { item1.SetActive(false); }
                NA.SetActive(true);
            }     
        }

        else if(valence == 2)
        {
            elementPanel.SetActive(true);
            if(shell==1)
            {
                NA.SetActive(false);
                group2[0].SetActive(true);
                Read_Data("beryllium");
            }

            else if(shell==2)
            {
                NA.SetActive(false);
                group2[1].SetActive(true);
                Read_Data("magnesium");
            }

            else if(shell==3)
            {
                NA.SetActive(false);
                group2[2].SetActive(true);
                Read_Data("calsium");
            }

            else if(shell==4)
            {
                NA.SetActive(false);
                group2[3].SetActive(true);
                Read_Data("strontium");
            }

            else if(shell==4)
            {
                NA.SetActive(false);
                group2[4].SetActive(true);
                Read_Data("barium");
            }

            else
            {
                elementPanel.SetActive(false);
                foreach (var item1 in group1)
                { item1.SetActive(false); }
                NA.SetActive(true);
            }     
        }

        else if(valence == 3)
        {
            elementPanel.SetActive(true);
            if(shell==1)
            {
                NA.SetActive(false);
                group17[0].SetActive(true);
                Read_Data("fluorine");
            }

            else if(shell==2)
            {
                NA.SetActive(false);
                group17[1].SetActive(true);
                Read_Data("chlorine");
            }

            else if(shell==3)
            {
                NA.SetActive(false);
                group17[2].SetActive(true);
                Read_Data("bromine");
            }

            else if(shell==4)
            {
                NA.SetActive(false);
                group17[3].SetActive(true);
                Read_Data("iodine");
            }

            else if(shell==4)
            {
                NA.SetActive(false);
                group17[4].SetActive(true);
                Read_Data("astatine");
            }

            else
            {
                elementPanel.SetActive(false);
                foreach (var item1 in group1)
                { item1.SetActive(false); }
                NA.SetActive(true);
            }     
        }

        else if(valence == 1)
        {
            elementPanel.SetActive(true);
            if(shell==1)
            {
                NA.SetActive(false);
                group18[0].SetActive(true);
                Read_Data("helium");
            }

            else if(shell==2)
            {
                NA.SetActive(false);
                group18[1].SetActive(true);
                Read_Data("neon");
            }

            else if(shell==3)
            {
                NA.SetActive(false);
                group18[2].SetActive(true);
                Read_Data("argon");
            }

            else if(shell==4)
            {
                NA.SetActive(false);
                group18[3].SetActive(true);
                Read_Data("krypton");
            }

            else if(shell==4)
            {
                NA.SetActive(false);
                group18[4].SetActive(true);
                Read_Data("xenon");
            }

            else if(shell==4)
            {
                NA.SetActive(false);
                group18[5].SetActive(true);
                Read_Data("radon");
            }

            else
            {
                elementPanel.SetActive(false);
                foreach (var item1 in group1)
                { item1.SetActive(false); }
                NA.SetActive(true);
            }     
        }

         else
        {
            elementPanel.SetActive(false);
            NA.SetActive(true);
        }
        
    }
}
