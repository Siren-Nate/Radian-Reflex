using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public GameObject player;
    private PlayerCollision healthCheck;
    private Vector2 healthScale;

    private void Start(){
        player = GameObject.FindWithTag("Player");
        healthCheck = player.GetComponent<PlayerCollision>();
    }

    void Update(){
        healthScale = new Vector2(transform.localScale.x, healthCheck.playerHP);
        transform.localScale = healthScale;
    }
}
