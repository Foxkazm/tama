using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class focusTab : MonoBehaviour
{
    public tabTracker tabber;
    public GameObject canvas;
    public SpriteRenderer mon;
    bool menOn=false;
    public bool gameOver=true;
    public int waitTime=100;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)&& waitTime<=0 && gameOver){
            tabOnOff();
            waitTime=500;
        }
        waitTime--;
    }
    public void tabOnOff(){
        if(menOn==false){
            canvas.SetActive(true);
            menOn=true;
            tabber.stopMove=true;
            gameOver=false;
        }else{
            canvas.SetActive(false);
            menOn=false;
            tabber.stopMove=false;
            gameOver=true;
            waitTime=500;
        }
    }
}
