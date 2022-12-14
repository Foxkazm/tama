using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabTracker : MonoBehaviour
{
    public GameObject [] tabVis;
    private int tabNum=0;
    public int waitTime=0;
    
    public bool stopMove=false;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=1; i<=tabVis.Length-1; i++){
        turnOnOff(tabVis[i],false);
        }
    }

    // Update is called once per frame
    void Update()
    {
            moveTabs();
        
    }
    void moveTabs(){
        if(!stopMove){
            if(Input.GetKey(KeyCode.RightArrow) && waitTime<=0){
                turnOnOff(tabVis[tabNum],false);
                tabNum++;
                if(tabNum>tabVis.Length-1){
                    tabNum=0;
                }

                
                waitTime=200;
            }
        
            if(Input.GetKey(KeyCode.LeftArrow) && waitTime<=0){
                turnOnOff(tabVis[tabNum],false);
                tabNum--;
                if(tabNum<0){
                    tabNum=tabVis.Length-1;
                }

                
                waitTime=200;
            }
        turnOnOff(tabVis[tabNum],true);
        waitTime--;
        }
    }
    void turnOnOff(GameObject item, bool onOff){
        item.SetActive(onOff);
   }
   

}
