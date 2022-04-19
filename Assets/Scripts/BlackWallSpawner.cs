using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackWallSpawner : MonoBehaviour
{

    public GameObject miniWall;
    private GameObject currentWall;
    public float dist = 0;

    private void Start()
    {
        currentWall = Instantiate(miniWall, transform);
    }

    private void Update()
    {
        instantiateAnotherWall();
    }

    private void instantiateAnotherWall()
    {
        dist = Vector2.Distance(transform.position, currentWall.transform.position);
        if (dist > 12)
        {
            currentWall = Instantiate(miniWall, transform);
        }
    }


}
