using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //create an array of spawn points, assigned in inspector
    public Transform[] collectablesSpawnPoints = new Transform[5];

    //create an array of collectables to choose from
    public GameObject[] items = new GameObject[3];

    // Use this for initialization
    void Start()
    {
        SpawnCollectable();
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public Transform GetCollectablesSpawnPoints()
    {
        int index = Random.Range(0, collectablesSpawnPoints.Length);
        return collectablesSpawnPoints[index];
    }

    public GameObject GetCollectables()
    {
        int index = Random.Range(0, items.Length);
        return items[index];
    }

    public GameObject SpawnCollectable()
    {
        Transform spawnPoint = GetCollectablesSpawnPoints();
        GameObject collectable = GetCollectables();
        GameObject c = Instantiate(collectable, spawnPoint.position, spawnPoint.rotation) as GameObject;
        return c;
    }

}
