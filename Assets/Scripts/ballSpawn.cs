using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpawn : MonoBehaviour
{
    public GameObject redBall;
    public GameObject blueBall;

    public Transform spawnLocation;   
    public float spawnInterval = 5f;

    private float ballCount = 0f;
    public float MaxBalls = 5f;

    private float blueCount = 0f;
    public float blueMax = 1f;

    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, spawnInterval);
    }

    void SpawnObject()
    {
        if(ballCount < MaxBalls)
        {
            Instantiate(redBall, spawnLocation.position, Quaternion.identity);
            ballCount++;
        }
        else if(blueCount < blueMax)
        {
            Instantiate(blueBall, spawnLocation.position, Quaternion.identity);
            blueCount++;
        }
    }

    
}
