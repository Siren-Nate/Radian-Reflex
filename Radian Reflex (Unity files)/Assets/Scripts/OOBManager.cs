using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOBManager : MonoBehaviour
{
    private float verticalBound = 9.0f;
    private float horizontalBound = 17.0f;

    void Update(){
        if ((transform.position.y > verticalBound)||(transform.position.y < -verticalBound)||(transform.position.x < -horizontalBound)||(transform.position.x > horizontalBound)){
            Destroy(gameObject);
        }
    }
}