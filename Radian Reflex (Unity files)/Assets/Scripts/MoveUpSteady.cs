using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpSteady : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject player;
    private PlayerController isTimeSlowed;

    private void Start(){
        player = GameObject.FindWithTag("Player");
        isTimeSlowed = player.GetComponent<PlayerController>();
    }

    void Update(){
        if(isTimeSlowed.timeSlowed == true){
            speed = 2.5f;
        }else{
            speed = 5.0f;
        }
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
