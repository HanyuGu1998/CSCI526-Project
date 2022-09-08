using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "bullet";
    }

    // Update is called once per frame
    void Update()
    {   
        transform.position = new Vector3(transform.position.x, (transform.position.y+0.02f));
        if (transform.position.y >= 6){
            transform.position = new Vector3(tank.getX(), tank.getY());
        }
    }
}
