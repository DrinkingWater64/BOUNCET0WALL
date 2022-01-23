using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteWallMini : MonoBehaviour
{
    public float speed;

    virtual public void WallMove()
    {
        transform.Translate(Vector3.up * Time.deltaTime * GameManager.instance.speed);
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
