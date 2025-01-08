using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 6.0f;
    public float xRange = 8.5f;
    public float yRange = 4.5f;

    public GameObject projectilePrefab;

    public bool timeSlowed;
    public float timeEnergy = 15.0f;

    AudioSource playerAudio;
    public AudioClip fireSound;

    void Start(){
        // This needs to be here so that the cursor is invisible during gameplay
        Cursor.visible = false;
        playerAudio = GetComponent<AudioSource>();
    }

    void Update(){
        // Get player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Use player input to move
        transform.Translate(Vector3.up * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.left * verticalInput * Time.deltaTime * speed);
        // These if statements keep them from going out of bounds
        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.y < -yRange) {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }
        if (transform.position.y > yRange) {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }
        // Launch projectiles in the direction of the arrow key pressed - comment this code out if I want to try the idea of purely dodge and crossfire-based gameplay
        if (Input.GetKeyDown(KeyCode.RightArrow)){
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            playerAudio.PlayOneShot(fireSound, 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)){
            Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0, 0, 0));
            playerAudio.PlayOneShot(fireSound, 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0, 0, 180));
            playerAudio.PlayOneShot(fireSound, 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0, 0, 270));
            playerAudio.PlayOneShot(fireSound, 0.1f);
        }
        // Activate slow time when spacebar is held down, return to normal when it is released
        if (Input.GetKeyDown(KeyCode.Space)){
            timeSlowed = true;
        }
        if (Input.GetKeyUp(KeyCode.Space)){
            timeSlowed = false;
        }
        // Drain the slow-time ability whenever it is active and recharge whenever it isn't
        if (timeSlowed){
            timeEnergy -= 0.01f;
        }
        if (!timeSlowed && timeEnergy<15.0f){
            timeEnergy += 0.01f;
        }
        // If the energy for slow-time runs out, have time return to normal
        if (timeEnergy<0.01f){
            timeSlowed = false;
        }
        // Increase the player's movement speed if time is slowed
        if(timeSlowed){
            speed = 10.0f;
        }else{
            speed = 6.0f;
        }
    }
}