using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject[] ElementImage;
    public GameObject backButton;
public void closeElement()
{
    foreach (var item in ElementImage)
        {
            item.SetActive(false);
        }
    backButton.SetActive(true);
}
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
