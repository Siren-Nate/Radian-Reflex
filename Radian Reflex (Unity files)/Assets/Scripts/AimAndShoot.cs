using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimAndShoot : MonoBehaviour
{
    public Transform target;
    public GameObject projectilePrefab;
    
    void Start()
    { InvokeRepeating("ShootProjectile", 2.0f, 1.0f); }

    void Update()
    {
        // Rotate the enemy every frame to aim at the player
        transform.LookAt(target);
        transform.Rotate(Vector3.up * 90);
    }

    void ShootProjectile(){
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.localRotation);
    }
}
