using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    public static float health;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, (transform.position.y-0.003f));
        if (health < 1 || transform.position.y < -5){
            transform.position = new Vector3((tank.getX()+100)%13-7, 4.90f);
            health = 100;
        }
    }

    void OnCollisionEnter2D(Collision2D other){ 
        if (other.gameObject.tag == "bullet"){
            GetComponent<SpriteRenderer>().color = Color.red; 
            health = health - 40;
        }
    }

    void OnCollisionExit2D(Collision2D other){
        if (other.gameObject.tag == "bullet"){
            GetComponent<SpriteRenderer>().color = Color.white; 
        }  
    }
}
