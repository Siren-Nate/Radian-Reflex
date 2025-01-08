using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveApproach : MonoBehaviour
{
    public float speed = 15.0f;

    void Update(){
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        if(speed>.01){
            speed *= 0.99f;
        } else {
            speed = 0.0f;
        }
    }
}
