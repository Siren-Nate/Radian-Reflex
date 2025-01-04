using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimAndShoot : MonoBehaviour
{
    public GameObject target;
    public GameObject projectilePrefab;
    
    void Start(){
        target = GameObject.FindWithTag("Player");
        InvokeRepeating("ShootProjectile", 2.0f, 1.0f);
    }

    void Update(){
        // Rotate the enemy every frame to aim at the player
        Vector3 lookDirection = target.transform.position;
        transform.LookAt(lookDirection);
        transform.Rotate(Vector3.up * 90);
        transform.Rotate(Vector3.forward * 90);
    }

    void ShootProjectile(){
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.localRotation);
    }
}
