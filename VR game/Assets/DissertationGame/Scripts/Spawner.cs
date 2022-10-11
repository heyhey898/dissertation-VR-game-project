using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Size of the spawner area")]
    public Vector3 spawnerSize;

    [Header("Spawning rate")]
    public float spawnRate = 1f;

    [Header("Model to spawn")]
    [SerializeField] private GameObject asteriodModel;

    private float spawnTimer = 0f;
    //private float spawnRate = 0f;


    // to visualize where the spawner box is
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        Gizmos.DrawCube(transform.position, spawnerSize);
    }

    private void Update()
    {
        if (GameController.currentGameStatus != GameController.GameState.Playing)
            return;

        spawnTimer += Time.deltaTime;

        if (spawnTimer > spawnRate)
        {
            Debug.Log("Spawning");
            spawnTimer = 0;
            SpawnAsteriod();
        }
    }
    
    
    /*
    private void Update()
    {
        if (GameController.currentGameStatus != GameController.GameState.Playing)
            return;

        spawnTimer += Time.deltaTime;
        spawnRate = UnityEngine.Random.Range(10f, 20f);

        if (spawnTimer > spawnRate)
        {
            Debug.Log("Spawning");
            spawnTimer = 0;
            SpawnAsteriod();
        }
    }
    */

    public void SpawnAsteriod()
    {
        //get a random position for the asteroid 
        Vector3 spawnPoint = transform.position + new Vector3(UnityEngine.Random.Range(-spawnerSize.x / 2, spawnerSize.x / 2),
                                                              UnityEngine.Random.Range(-spawnerSize.y / 2, spawnerSize.y / 2),
                                                              UnityEngine.Random.Range(-spawnerSize.z / 2, spawnerSize.z / 2));

        GameObject asteroid = Instantiate(asteriodModel, spawnPoint, transform.rotation);

        asteroid.transform.SetParent(this.transform);
    }
}
