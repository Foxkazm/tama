using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wither : MonoBehaviour
{
    public int ttl=200;
    public Transform subject;
    bool stage1=false;
    bool stage2=false;
    public GameObject self;
    // Update is called once per frame
    void Start(){
    }
    void Update()
    {   

        if(ttl<0){
            if(!stage1){
                subject.localScale= new Vector3(subject.localScale.x/4,subject.localScale.y,subject.localScale.z);
                stage1=true;
                ttl=200;
            }else if(!stage2){
                subject.localScale= new Vector3(subject.localScale.x/4,subject.localScale.y,subject.localScale.z);
                stage2=true;
                ttl=200;
            }else{
                Destroy(self);
            }

        }

        ttl--;
    }
}
