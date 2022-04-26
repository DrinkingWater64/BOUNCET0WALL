using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticWallB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        collision.transform.Translate(Vector3.down * Time.deltaTime * GameManager.instance.speed);
    }
}
