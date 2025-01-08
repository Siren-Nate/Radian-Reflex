using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectileMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject player;
    private PlayerController isTimeSlowed;

    private void Start(){
        player = GameObject.FindWithTag("Player");
        isTimeSlowed = player.GetComponent<PlayerController>();
    }

    void Update(){
        if(isTimeSlowed.timeSlowed == true){
            speed = 20.0f;
        }else{
            speed = 10.0f;
        }
        transform.Translate(Vector3.down * Time.deltaTime * speed);
    }
}
