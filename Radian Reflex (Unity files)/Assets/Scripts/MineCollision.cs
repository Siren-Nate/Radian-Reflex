using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineCollision : MonoBehaviour
{
    public GameObject projectilePrefab;

    void OnTriggerEnter2D(Collider2D other){
        //Instantiate(projectilePrefab, new Vector3(transform.position, transform.position, transform.position), Quaternion.Euler(0, 0, 0));
        Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0, 0, 0));
        Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0, 0, 60));
        Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0, 0, 120));
        Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0, 0, 180));
        Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0, 0, 240));
        Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0, 0, 300));
        Destroy(gameObject);
    }
}
