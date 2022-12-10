using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statDisplayer : MonoBehaviour
{
    public Monster monStats;
    public string statname;
    int stat;
    public GameObject [] hearts;
    // Start is called before the first frame update
    void Start()
    {
        getStats();
        int lastHeart=0;
        for(int i=0 ; i<stat; i++){
            hearts[i].SetActive(true);
            lastHeart=i+1;
        }
        for(int i=lastHeart ; i<hearts.Length; i++){
            hearts[i].SetActive(false);
        }

    }
    void getStats(){
        if(statname=="happiness"){
            stat=monStats.happiness;
        }
    }


}
