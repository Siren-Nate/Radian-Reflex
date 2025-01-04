using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpSteady : MonoBehaviour
{
    public float speed = 7.5f;

    void Update(){
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
