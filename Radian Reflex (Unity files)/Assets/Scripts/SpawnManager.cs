using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    public GameObject[ ] fromTheTop;
    public GameObject[ ] fromTheBottom;
    public GameObject fromTheRight;
    public GameObject player;

    public float spawnRangeX = 8.4f;
    public float spawnPointX = 8.4f;
    public float spawnRangeY = 4.4f;
    public float spawnPointY = 4.4f;

    AudioSource playerAudio;
    public AudioClip deathSound;
    public ParticleSystem explosionParticle;

    void Start(){
        playerAudio = GetComponent<AudioSource>();
        player = GameObject.Find("Player");
        StartCoroutine("SpawnWaves");
        InvokeRepeating("CheckPlayerDeath", 0.1f, 0.1f);
        //explosionParticle = GetComponent<ParticleSystem>();
    }

    IEnumerator SpawnWaves(){
        while (true) {
        int waveType = Random.Range(1, 4);
        switch (waveType){
            case 1: //Spawn single mine or enemy moving down from the top at a random horizontal position
                int topIndex = Random.Range(0, fromTheTop.Length);
                Vector3 spawnPos1 = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPointY, 0);
                Instantiate(fromTheTop[topIndex], spawnPos1, fromTheTop[topIndex].transform.rotation);
                break;
            case 2: //Spawn single mine or enemy moving up from the bottom at a random horizontal position
                int bottomIndex = Random.Range(0, fromTheBottom.Length);
                Vector3 spawnPos2 = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), -spawnPointY, 0);
                Instantiate(fromTheBottom[bottomIndex], spawnPos2, fromTheTop[bottomIndex].transform.rotation);
                break;
            case 3: //Spawn single enemy from the right at a random vertical position
                Vector3 spawnPos3 = new Vector3(spawnPointX, Random.Range(-spawnRangeY, spawnRangeY), 0);
                Instantiate(fromTheRight, spawnPos3, fromTheRight.transform.rotation);
                break;
            }
            if(player.activeSelf == true){
                yield return new WaitForSeconds(Random.Range(1.0f, 3.0f));
            }
        }
    }

    void CheckPlayerDeath(){
        if(player == null){
            explosionParticle.Play();
            playerAudio.PlayOneShot(deathSound, 0.5f);
            CancelInvoke("CheckPlayerDeath");
            Invoke("GoBackToMenu", 5);
        }else{
            transform.position = player.transform.position;
        }
    }

    void GoBackToMenu(){
        SceneManager.LoadScene("Title Screen", LoadSceneMode.Single);
    }
}