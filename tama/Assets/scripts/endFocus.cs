using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endFocus : MonoBehaviour
{
    public focusTab focus;
    int waitTime=300;
    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.Space)&& waitTime<=0 ){
            waitTime=300;
            focus.tabOnOff() ;
        }
    waitTime--;
    }
}
