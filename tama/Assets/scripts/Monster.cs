using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int happiness;
    public GameObject O;
    int leftMax= 0;
    int rightMax= 9;
    int topMax= 4;
    int bottomMax= -4;
    Vector2 targetPos;
    public int speed=1;
    int waitTime=500;
    void Start()
    {
        pickNewTargetPos();
    }

    void Update()
    {   Vector2 currentPos= transform.position;
        if(currentPos==targetPos && waitTime==0){
            pickNewTargetPos();
            waitTime=Random.Range(100,800);
        }else if(currentPos==targetPos){
            waitTime--;
        }else if(currentPos!=targetPos){
        float step=speed * Time.deltaTime;
        transform.position= Vector2.MoveTowards(transform.position, targetPos,step);
        }

    }
    void pickNewTargetPos(){
        targetPos=new Vector2(Random.Range(leftMax,rightMax),Random.Range(topMax,bottomMax));
    }

}
