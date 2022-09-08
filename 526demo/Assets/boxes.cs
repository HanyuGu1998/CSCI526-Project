using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, (transform.position.y-0.001f));
        if (transform.position.y < -5){
            transform.position = new Vector3((transform.position.x+100)%13-7, 4.90f);
        }
    }
}

   