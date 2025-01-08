using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBar : MonoBehaviour
{
    public GameObject player;
    private PlayerController energyCheck;
    private Vector2 energyScale;

    private void Start(){
        player = GameObject.FindWithTag("Player");
        energyCheck = player.GetComponent<PlayerController>();
    }

    void Update(){
        energyScale = new Vector2(energyCheck.timeEnergy, transform.localScale.y);
        transform.localScale = energyScale;
    }
}
