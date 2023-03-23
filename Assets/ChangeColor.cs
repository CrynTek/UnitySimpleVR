using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void getRed(){
         GetComponent<Renderer>().material.color = new Color(255f/255f, 69f/255f, 0f/255f); 
    }
    public void getSilver(){
        GetComponent<Renderer>().material.color = new Color(192f/255f, 192f/255f, 192f/255f); 
    }
    public void getPurple(){
        GetComponent<Renderer>().material.color = new Color(110f/255f, 44f/255f, 79f/255f); 
    }
    public void getGold(){
         GetComponent<Renderer>().material.color = new Color(218f/255f, 165f/255f, 32f/255f); 
    }
    public void getGrayDark(){
        GetComponent<Renderer>().material.color = new Color(90f/255f, 90f/255f, 90f/255f); 
    }
    public void getOrange(){
        GetComponent<Renderer>().material.color = new Color(193f/255f, 98f/255f, 26f/255f); 
    }
}
