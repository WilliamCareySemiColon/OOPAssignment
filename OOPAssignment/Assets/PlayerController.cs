using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float rotationSpeed = 150f;
    public float moveSpeed = 20.0f;
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) && moveSpeed < 500f)
        {
            moveSpeed += 50;
        }

        if (Input.GetKey(KeyCode.S) && moveSpeed > 0f)
        {
            moveSpeed -= 50;
        }

        if (Input.GetKey(KeyCode.A))
        {
            // Rotate counterclockwise
            transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            // Rotate clockwise
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            //move down
            transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            // move up
            transform.Rotate(-rotationSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            //spin left
            transform.Rotate(0,0, rotationSpeed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.X))
        {
            //spin right
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }

        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (moveSpeed > 500)
            moveSpeed = 500;

        if (moveSpeed < 0)
            moveSpeed = 0;
    }
}
