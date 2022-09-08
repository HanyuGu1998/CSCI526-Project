using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    public static float MoveSpeed=5;
    public static float Health = 100;
    public static Vector2 position;

    public static void speedChange(float newSpeed){
        MoveSpeed = newSpeed;
    }
 
    void Start()
    {
        
    }
 
    void Update()
    {
        position = transform.position;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        position.x = position.x + MoveSpeed * h* Time.deltaTime;
        position.y = position.y + MoveSpeed * v* Time.deltaTime;
        transform.position = position;
    }

    public static float getX(){
        return position.x;
    }

    public static float getY(){
        return position.y;
    }
    
    private void OnMouseDrag(){
       Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       transform.position = new Vector3(newPosition.x, newPosition.y);
    }

    

}
