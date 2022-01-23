using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float speed;
    public float length;
    public float startPos;

    public GameObject whiteWalls;

    private void Start()
    {
        startPos = whiteWalls.transform.position.y;
        length = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
    }
    virtual public void WallMove()
    {
        transform.Translate(Vector3.up * Time.deltaTime * GameManager.instance.speed);
    }

    virtual public void ResetWall()
    {
        transform.position = new Vector3(transform.position.x, startPos - length, transform.position.z);
    }

    private void OnBecameInvisible()
    {
        ResetWall();
    }
}
