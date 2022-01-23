using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackWallMini : MonoBehaviour
{
    public float speed;

    virtual public void WallMove()
    {
        transform.Translate(Vector3.up * Time.deltaTime * GameManager.instance.speed*-1);
    }


    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        WallMove();
    }
}
