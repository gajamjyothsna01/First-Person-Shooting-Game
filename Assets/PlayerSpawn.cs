using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{

    public Transform playerSpawnPoints; //Parent of the SPAWN points
    Transform[] spawnPositions;
   public bool isRespawn = false;
    public bool isSRespawnToggle = false;
    //int k;

    // Start is called before the first frame update
    void Start()
    {
        spawnPositions = playerSpawnPoints.GetComponentsInChildren<Transform>();
       // RandomSpawn();
        Debug.Log(spawnPositions.Length);
        
    }

    private void RandomSpawn()
    {
        int i = UnityEngine.Random.Range(1, spawnPositions.Length);
        
        Debug.Log(spawnPositions[i].transform.position);
        transform.position = spawnPositions[i].transform.position;

        //return (i);


    }

    // Update is called once per frame
    void Update()
    {/*
        if(isSRespawnToggle !=isRespawn)
        {
            RandomSpawn();
            isRespawn = false;
        }
        else
        {
            isSRespawnToggle = isRespawn;
        }*/
        if(Input.GetKeyUp(KeyCode.Space))
        {
            RandomSpawn();
        }
        
        
    }
}
