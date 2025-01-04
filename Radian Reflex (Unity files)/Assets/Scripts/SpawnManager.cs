using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[ ] fromTheTop;
    public GameObject[ ] fromTheBottom;
    public GameObject fromTheRight;

    public float spawnRangeX = 8.4f;
    public float spawnPointX = 8.4f;
    public float spawnRangeY = 4.4f;
    public float spawnPointY = 4.4f;

    void Start(){
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves(){
        while (true) {
        int waveType = Random.Range(1, 3);
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
            case 4: // 
                
                break;
            }
            yield return new WaitForSeconds(Random.Range(1.0f, 3.0f));
        }
    }
}
