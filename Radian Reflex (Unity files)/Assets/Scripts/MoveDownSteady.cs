using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSteady : MonoBehaviour
{
    public float speed = 15.0f;

    void Update(){
        transform.Translate(Vector3.down * Time.deltaTime * speed);
    }
}
