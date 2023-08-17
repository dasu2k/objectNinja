using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] targets;

    //used for instantiating new target obejects
    Vector3 SpawnLoc;
    Quaternion spawnRotation;

    //shit to control spawn timings between each spawn
    public float maxSpawnTime = 1.3f;
    public float minSpawnTime = 0.3f;
    float nextSpawn=0f;
    

    Menu menu ;
     
    void Start()
    {
        //getting an instance of the Menu to access the 'isPaused' attribute
        menu = FindObjectOfType<Menu>();
        spawnRotation = Quaternion.identity;
    }

    void Update()
    {
        Debug.Log(Time.time);
        
        if(Time.time >= nextSpawn && !menu.isPaused)
        {
            //spawning the target
            SpawnLoc = new Vector3(Random.Range(-5,5),0f,0f);
            GameObject target = Instantiate(targets[Random.Range(0,5)],SpawnLoc, spawnRotation);
            
            //adding forces to the target so that it would rotate and go up at first
            target.GetComponent<Rigidbody>().AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);
            target.GetComponent<Rigidbody>().AddTorque(Random.Range(-10, 10), Random.Range(-10, 10),Random.Range(-10, 10), ForceMode.Impulse);

            //set the time for the next spawn
            nextSpawn = Time.time + Random.Range(0.3f,1.4f);
        }
    }
}
