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
    public bool canPoint;
    private void Start()
    {
        PauseMenu.onTutorial += setCanPoint;
        canPoint = false;
    }

    private void setCanPoint(PauseMenu obj)
    {
        if(obj.isPaused == false)
        {
            canPoint = true;
            PauseMenu.onTutorial -= setCanPoint;
        }
    }

    private void Update()
    {
        if(currentPoint == null && canPoint == true)
        {
            currentPoint = Instantiate(point, getRandomPosition());
        }
    }

    private Transform getRandomPosition()
    {
        randomh = Random.Range(-12, 12);
        rand = Random.Range(0,3);
        Transform spawnPoint = gameObject.transform.GetChild(rand);
        newPos = new Vector3(spawnPoint.position.x, randomh, spawnPoint.position.z);
        spawnhere.position = newPos;
        return spawnhere;
    }
}
