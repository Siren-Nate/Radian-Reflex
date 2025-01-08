using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public int playerHP = 10;

    void Start(){
        InvokeRepeating("Counter", 0, 1);
    }

    //Colliding with enemies or enemy projectiles or mine projectiles does one damage, colliding with mines does not set them off
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Enemy")){
            Destroy(other.gameObject);
            playerHP--;
        }else if (other.gameObject.CompareTag("Enemy Projectile")){
            Destroy(other.gameObject);
            playerHP--;
        }else if (other.gameObject.CompareTag("Mine Projectile")){
            Destroy(other.gameObject);
            playerHP--;
        }
    }

    //Counts up while the player is still alive
    public TextMeshProUGUI scoreText;

    private int timeScore = 0;
    void Counter(){
        timeScore++;
        scoreText.text = "" + timeScore;
        if(playerHP < 1){
            scoreText.text = "You survived "+timeScore+" seconds.";
            Destroy(gameObject);
        }
    }
}
