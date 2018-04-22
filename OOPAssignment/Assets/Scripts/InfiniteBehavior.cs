using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteBehavior : MonoBehaviour
{ 
    public float moveSpeed;
    public float rotationSpeed;
    public float jumpSpeed;
    private bool inAir, dropDown;
    public  Rigidbody rigidbody;
    public GameObject ground;
    float offset;

    private void Start()
    {
        moveSpeed = 20.0f;
        rotationSpeed = 180f;
        jumpSpeed = 10;
        inAir = dropDown = false;
        rigidbody = GetComponent<Rigidbody>();
        offset = transform.position.y - ground.transform.position.y;
    }
    private void FixedUpdate()
    {
       // static int count = 1;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            // Move forwards
            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            // Move backwards
            transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            // Rotate counterclockwise
            transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        { 
            // Rotate clockwise
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            //go upwards
            transform.position += transform.up * jumpSpeed  * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.Return) && transform.position.y != ground.transform.position.y + offset)
        {
            //go downwards
            transform.position -= transform.up * jumpSpeed  * Time.deltaTime;

        }
    }
}
