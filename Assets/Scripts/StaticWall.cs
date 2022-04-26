using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticWall : MonoBehaviour
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
        //transform.Translate(Vector3.up * Time.deltaTime * GameManager.instance.speed);
        collision.transform.Translate(Vector3.up * Time.deltaTime * GameManager.instance.speed);
    }
}
