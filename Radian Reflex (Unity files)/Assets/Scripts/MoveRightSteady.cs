using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightSteady : MonoBehaviour
{
    public float speed = 15.0f;

    void Update(){
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
