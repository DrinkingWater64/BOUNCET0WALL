using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawner : MonoBehaviour
{
    public GameObject point;
    public GameObject currentPoint;
    public Transform spawnhere;
    public Vector3 newPos;
    public int rand;
    public float randomh;
    private void Start()
    {
        currentPoint = Instantiate(point, getRandomPosition());
    }

    private void Update()
    {
        if(currentPoint == null)
        {
            currentPoint = Instantiate(point, getRandomPosition());
        }
    }

    private Transform getRandomPosition()
    {
        randomh = Random.Range(-4, 4);
        rand = Random.Range(0,2);
        Transform spawnPoint = gameObject.transform.GetChild(rand);
        newPos = new Vector3(spawnPoint.position.x, randomh, spawnPoint.position.z);
        spawnhere.position = newPos;
        return spawnhere;
    }
}
