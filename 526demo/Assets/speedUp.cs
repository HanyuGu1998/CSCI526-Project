using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void sc(float i){
        tank.speedChange(i);
    }

    private void OnMouseDown(){
        sc(15);
        GetComponent<SpriteRenderer>().color = Color.red; 
    }

    private void OnMouseUp(){
        sc(5);
        GetComponent<SpriteRenderer>().color = Color.white; 
    }
}
