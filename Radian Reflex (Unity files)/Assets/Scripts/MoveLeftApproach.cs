using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftApproach : MonoBehaviour
{
    public float speed = 7.5f;

    void Update(){
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if(speed>.01){
            speed *= 0.99f;
        } else {
            speed = 0.0f;
        }
    }
}
