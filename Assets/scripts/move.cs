using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class move : MonoBehaviour
{
    public float baseSpeed = 3f;
    private float speed;
    void Start()
    {
        speed = baseSpeed * Time.deltaTime;               // Set the initial speed
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-speed, 0, 0);
            }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, speed, 0);
            }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, -speed, 0);
            }    
    }
}
