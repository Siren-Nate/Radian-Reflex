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

    // This needs to be here so that the cursor is invisible during gameplay
    void Start() {
        Cursor.visible = false;
    }

    void Update()
    {
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
        // Launch projectiles in the direction of the arrow key pressed - commenting this code out because I want to try the idea of purely dodge and crossfire-based gameplay
        if (Input.GetKeyDown(KeyCode.RightArrow)){
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)){
            Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0, 0, 180));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0, 0, 270));
        }
    }
}
