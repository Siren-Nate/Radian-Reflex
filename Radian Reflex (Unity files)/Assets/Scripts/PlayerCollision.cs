using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public int playerHP = 5;

    //Colliding with enemies or enemy projectiles does one damage, colliding with mines does not set them off
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Enemy")){
            Destroy(other.gameObject);
            playerHP = playerHP--;
            
        }else if (other.gameObject.CompareTag("Enemy Projectile")){
            Destroy(other.gameObject);
            playerHP--;
        }
        if(playerHP < 1){
            Destroy(gameObject);
        }
    }
}
