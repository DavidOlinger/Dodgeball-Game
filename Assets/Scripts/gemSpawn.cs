using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemSpawn : MonoBehaviour
{
    public GameObject coinPrefab;      

    public Vector2 areaSize = new Vector2(10f, 5f);
    public Vector2 areaCenter = Vector2.zero;     

    void Start()
    {
        SpawnCoin();
    }

    public void SpawnCoin()
    {
       
        Vector2 randomPosition = new Vector2(
            Random.Range(areaCenter.x - areaSize.x / 2, areaCenter.x + areaSize.x / 2),
            Random.Range(areaCenter.y - areaSize.y / 2, areaCenter.y + areaSize.y / 2)
        );

       
        Instantiate(coinPrefab, randomPosition, Quaternion.identity);
    }
}
