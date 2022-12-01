using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabTracker : MonoBehaviour
{
    string [] tab= new string []{"Food", "RG Light", "Play", "meds", "flush", "happiness", "disciplined", "attention"};
    public SpriteRenderer [] tabVis;
    private int tabNum=0;
    public string currentTab="Food";
     public int waitTime=0;
    // Start is called before the first frame update
    void Start()
    {
        
        turnOnOffRenderer(tabVis[0],true);
    }

    // Update is called once per frame
    void Update()
    {
        moveTabs();
    }
    void moveTabs(){
        if(Input.GetKey(KeyCode.RightArrow) && waitTime<=0){
            turnOnOffRenderer(tabVis[tabNum],false);
            tabNum++;
            if(tabNum>7){
                tabNum=0;
            }

            currentTab=tab[tabNum];
            Debug.Log(currentTab);
            waitTime=100;
        }
        
        if(Input.GetKey(KeyCode.LeftArrow) && waitTime<=0){
           turnOnOffRenderer(tabVis[tabNum],false);
            tabNum--;
            if(tabNum<0){
                tabNum=7;
            }

            currentTab=tab[tabNum];
            Debug.Log(currentTab);
            waitTime=100;
        }
        turnOnOffRenderer(tabVis[tabNum],true);
        waitTime--;
    }
    void turnOnOffRenderer(SpriteRenderer item, bool onOff){
        SpriteRenderer rend=tabVis[tabNum];
        
        rend.enabled=onOff;
   }
}
