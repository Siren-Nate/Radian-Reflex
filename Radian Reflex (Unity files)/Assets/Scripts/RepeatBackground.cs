using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private float speed = 2.0f;
    private Vector3 startPos;
    private float repeatPoint;
    public GameObject player;
    private PlayerController isTimeSlowed;

    void Start(){
        startPos = transform.position;
        repeatPoint = -9.1f;
        player = GameObject.FindWithTag("Player");
        isTimeSlowed = player.GetComponent<PlayerController>();
    }

    void Update(){
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (transform.position.x < repeatPoint){
            transform.position = startPos;
        }
        if(isTimeSlowed.timeSlowed == true){
            speed = 1.0f;
        }else{
            speed = 2.0f;
        }
    }
}
