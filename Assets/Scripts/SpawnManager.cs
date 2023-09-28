using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] animalPrefabs;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 35f;

    public float sideSpawnMinZ;

    public float sideSpawnMaxZ;

    public float sideSpawnX; 

    private float startDelay = 2;
    private float spawnInterval = 2.0f;
   

    // Start is called before the first frame update
    void Start()
    {
  
    // Invoke the SpawnRandomAnimal method at the specified interval
    InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

    // Invoke the SpawnLeftAnimal method at a different interval
    InvokeRepeating("SpawnLeftAnimal", startDelay, spawnInterval * 2); 

    // Invoke the SpawnRightAnimal method at yet another interval
    InvokeRepeating("SpawnRightAnimal", startDelay, spawnInterval * 3); 


    }

    // Update is called once per frame
    void Update()

    {
        
        
    }
     void SpawnRandomAnimal(){ //this function we wrote to make random animals from our array appear at random points along x axis
            
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
     }

     void SpawnLeftAnimal (){
       int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range (sideSpawnMinZ,sideSpawnMaxZ));
            Vector3 rotation = new Vector3 (0,90,0);
            Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
        
     }

     void SpawnRightAnimal (){
        int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range (sideSpawnMinZ,sideSpawnMaxZ));
            Vector3 rotation = new Vector3 (0,-90,0);
            Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
        
     }
}
