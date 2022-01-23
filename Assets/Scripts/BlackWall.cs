using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackWall : Wall
{
    public override void WallMove()
    {
        transform.Translate(Vector3.up * Time.deltaTime * GameManager.instance.speed*-1);
    }

    public override void ResetWall()
    {
        transform.position = new Vector3(transform.position.x, startPos + length, transform.position.z);
    }
    void Update()
    {
        WallMove();
    }
    
}
