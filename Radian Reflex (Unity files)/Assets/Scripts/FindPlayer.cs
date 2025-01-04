using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayer : MonoBehaviour
{
    public GameObject target;

    void Start(){
        target = GameObject.FindWithTag("Player");
        Vector3 lookDirection = target.transform.position;
        transform.LookAt(lookDirection);
        transform.Rotate(Vector3.up * 90);
        transform.Rotate(Vector3.forward * 90);
    }
}
