using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;
    public float rotationSpeed = 150f;
    public float moveSpeed = 10.0f;
    public float nextFire, fireRate;

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetButton("Fire1") || Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire))
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }

    private void FixedUpdate()
    {
        //move forward faster
        if (Input.GetKey(KeyCode.W) && moveSpeed < 250f)
        {
            moveSpeed += 5;
        }

        //move forward slower
        if (Input.GetKey(KeyCode.S) && moveSpeed > 0f)
        {
            moveSpeed -= 5;
        }

        if (Input.GetKey(KeyCode.E) && moveSpeed > 0)
        {
            //move down
            transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Q) && moveSpeed > 0)
        {
            // move up
            transform.Rotate(-rotationSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A) && moveSpeed == 0)
        {
            // Rotate counterclockwise if the ship is not moving 
            transform.Rotate(0, (-rotationSpeed * Time.deltaTime)/8, 0);
        }
        if (Input.GetKey(KeyCode.D) && moveSpeed == 0)
        {
            // Rotate clockwise if the ship is not moving 
            transform.Rotate(0, (rotationSpeed * Time.deltaTime)/8, 0);
        }

        if (Input.GetKey(KeyCode.A) && moveSpeed > 0)
        {
            // Rotate counterclockwise if the ship is moving 
            transform.Rotate(0, (-rotationSpeed * Time.deltaTime) / 8, 45 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) && moveSpeed > 0)
        {
            // Rotate clockwise if the ship is moving 
            transform.Rotate(0, (rotationSpeed * Time.deltaTime) / 8, -45 * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.Z))
        {
            //spin left
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.X))
        {
            //spin right
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }

        transform.Translate(0, 0, moveSpeed * Time.deltaTime);

        if (moveSpeed > 500)
            moveSpeed = 500;

        if (moveSpeed < 0)
            moveSpeed = 0;
    }

}   