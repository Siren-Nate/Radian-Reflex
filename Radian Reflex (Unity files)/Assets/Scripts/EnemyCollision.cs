using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public int enemyHP = 3;
    
    //Being hit by player projectiles lowers health, colliding with the player or being hit by mine projectiles instantly kills
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            Destroy(gameObject);
        }else if (other.gameObject.CompareTag("Player Projectile")){
            enemyHP--;
            Destroy(other.gameObject);
        }else if (other.gameObject.CompareTag("Mine Projectile")){
            Destroy(gameObject);
            Destroy(other.gameObject);
        //}else if (other.gameObject.CompareTag("Enemy Projectile")){
        //    Destroy(gameObject);
        //    Destroy(other.gameObject);
        }
        if (enemyHP < 1){
            Destroy(gameObject);
        }   
    }
}
