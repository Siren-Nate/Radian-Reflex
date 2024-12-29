using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftSteady : MonoBehaviour
{
    public float speed = 7.5f;

    void Update(){
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
