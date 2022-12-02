using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    public SpriteRenderer tab;
    public GameObject canvas;
    public SpriteRenderer mon;
    bool menOn=false;
    int waitTime=100;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)&& waitTime<=0){
            tabOnOff();
            waitTime=101;
        }
        waitTime--;
    }
    void tabOnOff(){
        if(menOn==false){
            tab.enabled=false;
            canvas.SetActive(true);
            menOn=true;
        }else{
            tab.enabled=true;
            canvas.SetActive(false);
            menOn=false;
        }
    }
}
