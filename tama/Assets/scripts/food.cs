using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    public GameObject [] tabVis;
    private int tabNum=0;
    public int waitTime=500;
    
    public focusTab focusScript;
  
    public GameObject foodAref;
    public GameObject foodBref;

    void Start()
    {
        for(int i=1; i<=tabVis.Length-1; i++){
        turnOnOff(tabVis[i],false);
        }
    }

    
    void Update()
    {
            moveTabs();
        if(Input.GetKey(KeyCode.Space) && waitTime<=0){
            if(tabNum==0){
                Debug.Log("A");
                Instantiate(foodAref,new Vector3(0,0,0),Quaternion.identity);
                Debug.Log(tabNum+"");
                waitTime=500;
                focusScript.tabOnOff();
                
            }else if (tabNum==1){
                Debug.Log("B");
                Instantiate(foodBref,new Vector3(0,0,0),Quaternion.identity);
                Debug.Log(tabNum+"");
                waitTime=500;
                focusScript.tabOnOff();

            }
            
        }

        }

    
    void moveTabs(){

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
        void turnOnOff(GameObject item, bool onOff){
            item.SetActive(onOff);
   }

    }
  
